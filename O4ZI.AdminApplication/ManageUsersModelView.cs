using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace O4ZI.AdminApplication
{
    public class ManageUsersViewModel
    {
        public ICollectionView Users { get; private set; }


        public ManageUsersViewModel()
        {
            var _users = new List<User>
                                 {
                                     new User
                                         {
                                             Username = "admin",
                                             Role = "Admin",
                                             Email = "admin@o4zi.org"
                                         },
                                         new User
                                         {
                                             Username = "student",
                                             Role = "Student",
                                             Email = "student@o4zi.org"
                                         },
                                         new User
                                         {
                                             Username = "teacher",
                                             Role = "Teacher",
                                             Email = "teacher@o4zi.org"
                                         },
                                         new User
                                         {
                                             Username = "guestlecturer",
                                             Role = "GuestLecturer",
                                             Email = "guestlecturer@o4zi.org"
                                         }


                                 };

            Users = CollectionViewSource.GetDefaultView(_users);
        }
    }

}
