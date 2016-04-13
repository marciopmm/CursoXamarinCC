using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace ConectCon.Models
{
    public class Post : INotifyPropertyChanged
    {
        [JsonProperty(PropertyName = "userId")]
        public int UserId { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Titulo { get; set; }

        [JsonProperty(PropertyName = "body")]
        public string Mensagem { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
