#region Disclaimer/License Info

/* *********************************************** */

// sBlog.Net

// sBlog.Net is a minimalistic blog engine software.

// Homepage: http://sblogproject.net
// Github: http://github.com/karthik25/sBlog.Net

// This project is licensed under the BSD license.  
// See the License.txt file for more information.

/* *********************************************** */

#endregion

using System.ComponentModel.DataAnnotations;
using sBlog.Net.MetaData.MetaData;

namespace sBlog.Net.Models.Account
{
    [MetadataType(typeof(NewUserModelMetaData))]
    public class NewUserModel
    {
        public string UserDisplayName { get; set; }
        public string UserEmailAddress { get; set; }
        public string Title { get; set; }
        public short RoleId { get; set; }
    }
}