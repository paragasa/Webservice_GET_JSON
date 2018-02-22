using System;
using SQLite;

namespace MasterDetailsCRUDi.Models
{
    public class Monster : Entity<Item>
    {
        public void Update(Monster newData)
        {
            if (newData == null)
            {
                return;
            }

            // Update all the fields in the Data, except for the Id
            Name = newData.Name;
            Description = newData.Description;
        }
    }
}