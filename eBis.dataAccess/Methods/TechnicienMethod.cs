﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBis.common.Models;
using MongoDB.Driver;
using eBis.dataAccess.Methods;

namespace eBis.dataAccess.Methods
{
    public class TechnicienMethod
    {
        private IMongoCollection<Technicien> _technicien;

        public TechnicienMethod()
        {
            _technicien = MongoDBHelper.eBisMongoBase.GetCollection<Technicien>("technicien");
        }

        // Récupère la liste des techniciens
        public List<Technicien> getAllTechniciens()
        {
            List<Technicien> tcn = _technicien.Find(s => true).ToList();
            return tcn;
        }

        // Récupère la liste des techniciens en fonction du secteur 
        public List<Technicien> getTechniciensBySecteur(Secteur secteur)
        {
            List<Technicien> tcnSecteur = new List<Technicien>();

            foreach (Technicien t in getAllTechniciens())
            {
                if (t.Secteur == secteur)
                    tcnSecteur.Add(t);
            }
            return tcnSecteur;
        }
    }
}