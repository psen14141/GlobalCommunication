using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GloableCommunication.DbModels;

namespace GloableCommunication.Models.ViewModels
{

    public class HomeViewModel
    {

        public int Training1 { get; set; }
        public int Training2 { get; set; }

        public int Training3 { get; set; }

        public int SpecificSkill1 { get; set; }

        public int SpecificSkill2 { get; set; }

        public int SpecificSkillTotal { get; set; }

        public int DuringResidence { get; set; }

        public int ReturnHome { get; set; }

        public int ReturnJapan { get; set; }

        public int Disappearance { get; set; }

        public int UnionTransfer { get; set; }
        public int Death { get; set; }

        public int TrainingTotal { get; set; }

        public int AllPersons { get; set; }

        public int CountryId { get; set; }
        public string CountryName { get; set; }

    }
}
