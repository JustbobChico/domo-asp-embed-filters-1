using System.ComponentModel.DataAnnotations;

namespace ProgrammaticFiltering.Models
{
    #region snippet1
    public class ProgrammaticFilter
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Filter { get; set; }
        public string EmbedId { get; set; }
        public string EmbedId2 { get; set; }
        public string EmbedId3 { get; set; }
        public string EmbedId4 { get; set; }
    }
    #endregion
}