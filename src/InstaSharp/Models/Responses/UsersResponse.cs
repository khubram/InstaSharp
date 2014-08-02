﻿using System.Collections.Generic;

namespace InstaSharp.Models.Responses
{
    /// <summary>
    /// 
    /// </summary>
    public class UsersResponse : Response
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public List<User> Data { get; set; }

        /// <summary>
        /// Gets or sets the pagination.
        /// </summary>
        /// <value>
        /// The pagination.
        /// </value>
        public Pagination Pagination { get; set; }
    }
}
