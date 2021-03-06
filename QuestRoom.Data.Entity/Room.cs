﻿using QuestRoom.Base.Abstractions;

using System.Collections.Generic;

namespace QuestRoom.Data.Entity
{
    public class Room : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string GroupSize { get; set; }
        public string MinimumAge { get; set; }
        public string Address { get; set; }
        public string PhoneNumbers { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public double Rating { get; set; }
        public int LevelComplexityId { get; set; }
        public int TypeRoomId { get; set; }
        public IEnumerable<Picture> Pictures { get; set; }
    }
}
