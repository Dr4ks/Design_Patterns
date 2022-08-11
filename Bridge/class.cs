using System;
namespace Bridge{
     class Message //Abstracton
    {
        protected IMessageSender _implementation;
        
        public Message(IMessageSender implementation)
        {
            this._implementation = implementation;
        }
        
      
    }

    class TextMessage : Message  //Refined Abstraction
    {
        public TextMessage(IMessageSender implementation) : base(implementation)
        {
        }
        
    }

    class EmailMessage : Message  //Refined Abstraction
    {
        public EmailMessage(IMessageSender implementation) : base(implementation){}
        
        
    }

    public interface IMessageSender //Implementation
    {
        string Send();
    }

    class TextMessageSender : IMessageSender //Concrete Implementation
    {
        public string Send()
        {
            return "TextMessageSender: Sending text message...\n";
        }
    }

    class EmailMessageSender : IMessageSender //Concrete Implementation
    {
        public string Send()
        {
            return "EmailMessageSender: Sending email message...\n";
        }
    }
}