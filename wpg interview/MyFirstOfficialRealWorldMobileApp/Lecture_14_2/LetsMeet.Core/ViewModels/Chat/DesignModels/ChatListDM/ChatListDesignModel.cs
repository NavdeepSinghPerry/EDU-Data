using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMeet.Core
{
   public class ChatListDesignModel : ChatListVM
    {
        public static ChatListDesignModel Instance => new ChatListDesignModel();
          public ChatListDesignModel()
         {
            Items=new List<ChatListItemVM>
            {
                new ChatListItemVM
                {
                    Name = "Gurpreet Singh",
                    Message = "This new chat app is awesome. I bet you will forget whatsapp",
                    InitialProfileText = "GS",
                    ProfilePictureRGB = "3099c5"
                },
                new ChatListItemVM
                {
                    Name = "Puneet Jain",
                    Message = "This new chat app is awesome. I bet you will forget whatsapp",
                    InitialProfileText = "PJ",
                    ProfilePictureRGB = "ff0000",
                    IsNewMessage=true
                },
                new ChatListItemVM
                {
                    Name = "Prince",
                    Message = "This new chat app is awesome. I bet you will forget whatsapp",
                    InitialProfileText = "PC",
                    ProfilePictureRGB = "67B7D1"
                },
                new ChatListItemVM
                {
                    Name = "Ishneet Saggu",
                    Message = "This new chat app is awesome. I bet you will forget whatsapp",
                    InitialProfileText = "IS",
                    ProfilePictureRGB = "ffc34d",
                    
                    
                },
                new ChatListItemVM
                {
                    Name = "Abhijeet Garg",
                    Message = "This new chat app is awesome. I bet you will forget whatsapp",
                    InitialProfileText = "AG",
                    ProfilePictureRGB = "009933"
                }, new ChatListItemVM
                {
                    Name = "Subham Singhania",
                    Message = "This new chat app is awesome. I bet you will forget whatsapp",
                    InitialProfileText = "SS",
                    ProfilePictureRGB = "3099c5",
                    IsSelected=true
                },
                new ChatListItemVM
                {
                    Name = "Akshay Rokade",
                    Message = "This new chat app is awesome. I bet you will forget whatsapp",
                    InitialProfileText = "AR",
                    ProfilePictureRGB = "ff0000"
                },
                new ChatListItemVM
                {
                    Name = "Kunal Singla",
                    Message = "This new chat app is awesome. I bet you will forget whatsapp",
                    InitialProfileText = "KS",
                    ProfilePictureRGB = "67B7D1"
                },
                new ChatListItemVM
                {
                    Name = "Nikhil Goyal",
                    Message = "This new chat app is awesome. I bet you will forget whatsapp",
                    InitialProfileText = "NG",
                    ProfilePictureRGB = "ffc34d"
                },
                new ChatListItemVM
                {
                    Name = "Deepneet Saggu",
                    Message = "This new chat app is awesome. I bet you will forget whatsapp",
                    InitialProfileText = "DS",
                    ProfilePictureRGB = "009933"
                }


            };

        }
    }
}
