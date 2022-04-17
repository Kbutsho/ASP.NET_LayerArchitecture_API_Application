using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Entities
{
    public class TokenModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string AccessToken { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public DateTime? ExpiredAt { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
