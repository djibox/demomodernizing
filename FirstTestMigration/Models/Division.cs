using System.Collections.Generic;

namespace FirstTestMigration.Models
{
    public class Division
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Agent> Agents { get; set; }
    }
}