﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseLibrary.Models
{
    public class Student_db
    {

        #region Constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Student_db()
        {
        }

        /// <summary>
        /// Fields constructor.
        /// </summary>
        public Student_db(string id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Id generated by our system upon creation of a new instance.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// First name used of the student.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name used of the student.
        /// </summary>
        public string LastName { get; set; }

        #endregion

    }
}
