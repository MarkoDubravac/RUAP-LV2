﻿using Lv2_Solution.Models;
using Lv2_Solution.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Lv2_Solution.Controllers
{
    public class ContactController : ApiController
    {
        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }

        // GET: Contact
        public Contact[] Get()
        {
            return this.contactRepository.GetAllContacts();
        }

        public HttpResponseMessage Post(Contact contact)
        {
            this.contactRepository.SaveContact(contact);

            var response = Request.CreateResponse<Contact>(System.Net.HttpStatusCode.Created, contact);

            return response;
        }
    }
}