using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videogame_DB.Domain.Entities
{
    public class PersonalGames : BaseEntity
    {
        public string? GameName { get; set; }

        public string? StartPlay { get; set; }

        public string? EndPlay { get; set; }

        public string? Score { get; set; }
    }
}
