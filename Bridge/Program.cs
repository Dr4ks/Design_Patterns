using System;
namespace Bridge{
    class Program{
        public static void Main(string[] args){
            IMessageSender textmessageSender=new TextMessageSender();
            Message textmessage=new TextMessage(textmessageSender);
            Console.WriteLine(textmessageSender.Send());

            IMessageSender emailmessageSender=new EmailMessageSender();
            Message emailmessage=new EmailMessage(emailmessageSender);
            Console.WriteLine(emailmessageSender.Send());
        }

    }    
}