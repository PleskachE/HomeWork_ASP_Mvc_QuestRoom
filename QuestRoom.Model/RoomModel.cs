﻿using QuestRoom.Data.Entity;

using System.Collections.Generic;

namespace QuestRoom.Model
{
    public class RoomModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string GroupSize { get; set; }
        public string MinimumAge { get; set; }
        public string Address { get; set; }
        public string PhoneNumbers { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Rating { get; set; }
        public string LevelComplexity { get; set; }
        public string LevelFear { get; set; }
        public IEnumerable<Picture> Pictures { get; set; }
    }
}
