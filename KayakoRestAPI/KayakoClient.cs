﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Net;
using System.Xml.Serialization;
using System.IO;
using KayakoRestApi.Core;
using KayakoRestApi.Controllers;
using KayakoRestApi.Net;
using System.Reflection;

namespace KayakoRestApi
{
    /// <summary>
    /// This service allows the interaction with the Kayako REST Api.
    /// </summary>
    /// <remarks>
    /// See - http://wiki.kayako.com/display/DEV/REST+Api
    /// </remarks>
    public class KayakoClient
	{
		#region Private Properties

		private DepartmentController _departments;
		private StaffController _staff;
		private TicketController _tickets;
		private UserController _users;

		#endregion

		#region Public Properies

		/// <summary>
		/// Provides access to Deparment API Methods
		/// </summary>
		public DepartmentController Departments
		{ 
			get { return _departments; }
		}

		/// <summary>
		/// Provides access to Staff API Methods
		/// </summary>
		public StaffController Staff
		{
			get { return _staff; }
		}

		/// <summary>
		/// Provides access to Ticket API Methods
		/// </summary>
		public TicketController Tickets
		{
			get { return _tickets; }
		}

		/// <summary>
		/// Provides access to User API Methods
		/// </summary>
		public UserController Users
		{
			get { return _users; }
		}

		#endregion

		/// <summary>
        /// Initializes a new instance of the KayakoRestApi.KayakoService class.
        /// </summary>
        /// <param name="apiKey">Api Key.</param>
        /// <param name="secretKey">Secret Api Key.</param>
        /// <param name="apiUrl">URL of Kayako REST Api</param>
        public KayakoClient(string apiKey, string secretKey, string apiUrl)
        {
			_departments = new DepartmentController(apiKey, secretKey, apiUrl);
			_staff = new StaffController(apiKey, secretKey, apiUrl);
			_tickets = new TicketController(apiKey, secretKey, apiUrl);
			_users = new UserController(apiKey, secretKey, apiUrl);
        }
    }
}