using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WishList.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
        /*Create a new class Item in the WishList/Models folder. (You might need to create this folder)
        This class should contain a public property Id of type int. This class should contain a public property Description of type string.
        The Description property should have attributes of Required and MaxLength(50). 
        (Note: You'll need to add a using statement for System.ComponentModel.DataAnnotations)*/

    }
}
