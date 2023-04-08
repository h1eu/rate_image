using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormRateIamge
{
    internal class User
    {
        public User(string name,string age, int gender,int shortSighted) {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.ShortSighted = shortSighted;
        }
        public string Name { get; set; }
        public string Age { get; set; }
        public int Gender { get; set; }
        public int ShortSighted { get; set; }

        public string displayUser()
        {
            string gender = "";
            string isShortSighted = "";
            
            if(Gender == 0)
            {
                gender = "nữ";
            } else if(Gender == 1) {
                gender = "nam";
            }

            if(ShortSighted == 0)
            {
                isShortSighted = "không";
            } else if (ShortSighted == 1)
            {
                isShortSighted = "có";
            }

            string user = "tên: " + Name + ", tuổi: " + Age + ", giới tính: " + gender + ", cận thị: " + isShortSighted + ".\n" ;
            return user;
        }
    }
}
