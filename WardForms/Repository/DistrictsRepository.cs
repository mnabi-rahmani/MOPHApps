﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WardForms.Models;
using WardForms.Repository;

namespace WardForms.Repository
{
    public class DistrictsRepository : Repository<District>
    {
     public   ApplicationDbContext Context = new ApplicationDbContext();

        public DistrictsRepository()
        {

        }

        public List<District> GetAllDistricts()
        {

           return  Context.Districts.Include("Province").ToList();


        }
        public void UpdateDistrict(District _district)
        {
            Context.Entry(_district).State = EntityState.Modified;
            Context.SaveChanges();

        }
    }
}