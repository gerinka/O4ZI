using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace O4ZI.AdminApplication
{
    public class ManageApplicationViewModel
    {
        public ICollectionView SocialNetworks { get; private set; }


        public ManageApplicationViewModel()
        {
            var _socialNetworks = new List<SocialNetwork>
                                 {
                                     new SocialNetwork
                                         {
                                             IsAvailable = true,
                                             Name = "facebook",
                                             Url = "https://www.facebook.com/"
                                         },
                                         new SocialNetwork
                                         {
                                             IsAvailable = true,
                                             Name = "twitter",
                                             Url = "https://twitter.com/"
                                         },
                                         new SocialNetwork
                                         {
                                             IsAvailable = true,
                                             Name = "youtube",
                                             Url = "https://www.youtube.com"
                                         }


                                 };

            SocialNetworks = CollectionViewSource.GetDefaultView(_socialNetworks);
        }
    }

}
