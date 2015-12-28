/*
 * Libreria para el envio de emails. Los ejemplos de uso son para
 * gmail, pero se puede aplicar a cualquier cuenta siempre
 * que se conozca los datos de smtp y seguridad ssl
 * Diego Machado.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail; //Contiene todas las funciones para el envio de email, disponible desde la version 2.0 del framework .net
using System.ComponentModel;



    public class EnviarMail
    {
        public static void SendMail(string from,string asunto,string body)
        {
            MailMessage msg=new MailMessage();

            msg.To.Add(new MailAddress("falcoyasociados@gmail.com"));
            msg.From=new MailAddress(from, from);
            msg.Subject = asunto;
            msg.Body = body;
            msg.IsBodyHtml = true;
            SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com");
            clienteSmtp.UseDefaultCredentials = true;
            clienteSmtp.Credentials = new System.Net.NetworkCredential("falcoyasociados@gmail.com", "defensa6969");
            clienteSmtp.EnableSsl = true;
           
            clienteSmtp.SendCompleted += new SendCompletedEventHandler(clienteSmtp_SendCompleted);
            try
            {
                clienteSmtp.Send(msg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static void clienteSmtp_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Console.WriteLine("Envío completo");
        }
    }

