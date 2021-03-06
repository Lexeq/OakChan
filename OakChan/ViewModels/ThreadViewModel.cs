﻿using System.Collections.Generic;

namespace OakChan.ViewModels
{
    public class ThreadViewModel
    {
        public string BoardId { get; set; }

        public int ThreadId { get; set; }

        public OpPostViewModel OpPost { get; set; }

        public IEnumerable<PostViewModel> Replies { get; set; }
    }
}
