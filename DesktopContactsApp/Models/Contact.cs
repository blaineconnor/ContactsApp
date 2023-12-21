using SQLite;

namespace DesktopContactsApp.Models
{
    [Table("CONTACTS")]
    public class Contact
    {
        [PrimaryKey, AutoIncrement, Column("ID")]
        public int Id { get; set; }

        [Column("NAME"), MaxLength(50)]
        public string Name { get; set; }

        [Column("EMAIL"), MaxLength(50)]
        public string Email { get; set; }

        [Column("PHONE"), MaxLength(10)]
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Email} - {Phone}";
        }
    }
}
