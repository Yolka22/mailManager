using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mailManager.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mailManager
{
    public partial class Form1 : Form
    {

        MailAddress from = new MailAddress("from@some_mail.com");

        private Model1 DB = new Model1();
        private void InitData()
        {
            DB.Contacts.Add(new Contact() { Email = "wasya@ukr.net"});
            DB.Contacts.Add(new Contact() { Email = "petya@ukr.net"});
            DB.Contacts.Add(new Contact() { Email = "kolya@ukr.net"});
            DB.Contacts.Add(new Contact() { Email = "dasha@ukr.net"});
            DB.Contacts.Add(new Contact() { Email = "sasha@ukr.net"});
            DB.SaveChanges();
            MessageBox.Show("init data - ok");
        }

        private void FillContactsList()
        {
            var CurrentContacts = DB.Contacts.ToList();
            ContactsChoose.Items.Clear();
            foreach (var contact in CurrentContacts)
            {
                ContactsChoose.Items.Add(contact.Email);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void adressTo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillContactsList();
        }

        private void ContactsChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получите выбранный элемент
            string selectedItem = ContactsChoose.SelectedItem.ToString();

            // Выполните действия на основе выбранного элемента
            ContactsChooseCopy.Items.Add($"{selectedItem}");
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            string Subject = SubjectTextBox.Text;
            string Body = MessageBodyField.Text;

            foreach (var item in ContactsChooseCopy.Items)
            {
                MailAddress target = new MailAddress(item.ToString());

                MailMessage message = new MailMessage(from, target);

                message.Subject = Subject;
                message.Body = Body;


                List<string> fileList = new List<string>();
                // Создаем массив путей к файлам, которые нужно прикрепить
                foreach (var FileStringPath in fileCopies.Items)
                {
                    fileList.Add(FileStringPath.ToString());
                }

                foreach (string filePath in fileList)
                {
                    Attachment attachment = new Attachment(filePath, MediaTypeNames.Application.Octet);
                    ContentDisposition disposition = attachment.ContentDisposition;
                    disposition.CreationDate = File.GetCreationTime(filePath);
                    disposition.ModificationDate = File.GetLastWriteTime(filePath);
                    disposition.ReadDate = File.GetLastAccessTime(filePath);
                    message.Attachments.Add(attachment);
                }



                int port = 2525;
                string host = "sandbox.smtp.mailtrap.io";
                string login = "68c6cb0edd6ba4";
                string password = "a29f7e64700674";

                SmtpClient smtpClient = new SmtpClient(host, port);
                smtpClient.Credentials = new NetworkCredential(login, password);

                smtpClient.Send(message);

                // Очищаем список вложений после отправки сообщения
                message.Attachments.Clear();
            }
        }

        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            // Создаем объект OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Title = "Выберите файлы для отправки"
            };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                // Прикрепляем выбранные файлы к письму
                foreach (string filePath in openFileDialog.FileNames)
                {
                    fileCopies.Items.Add(filePath);
                }
            }
            }
        }
    }
