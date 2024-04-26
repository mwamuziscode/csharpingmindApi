using System;


namespace csharpingmindApi.Models


{ 
    public class Permission()
    {
        public int? Id  { get; set; }
        public string ?Name  { get; set; }
        public string ? Description { get; set; }
        public int ? ContentTypeId { get; set; }
        public string? CodeName { get; set; }
    }
}