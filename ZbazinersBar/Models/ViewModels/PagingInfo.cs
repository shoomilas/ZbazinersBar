﻿using System;

namespace ZbazinersBar.Models.ViewModels {
    public class PagingInfo {
        public int ItemsPerPage { get; set; }
        public int TotalItems { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages =>
            (int)Math.Ceiling(
                (decimal)TotalItems / ItemsPerPage);
    }
}
