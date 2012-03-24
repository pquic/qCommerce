﻿using System.Collections.Generic;

namespace Nop.Web.Models.Boards
{
    public class BoardsIndexModel
    {
        public BoardsIndexModel()
        {
            this.ForumGroups = new List<ForumGroupModel>();
        }
        
        public IList<ForumGroupModel> ForumGroups { get; set; }
    }
}