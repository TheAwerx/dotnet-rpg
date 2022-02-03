using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;

namespace dotnet_rpg.DTOs.Character
{
    public class UpdateCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Jhin";
        public int HitPoints { get; set; } = 100;
        public int Power { get; set; } = 10;
        public int Armor { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Fighter;
    }
}