﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using TrackableEntities.Patterns.EF6;
using $baseNamespace$.EF.Contexts;
using $baseNamespace$.Entities.Models;
using $baseNamespace$.Persistence.Repositories;

namespace $rootnamespace$
{
    // NOTE: First add $entityName$ Repository Interface in Service.Persistence project
    
    public class $safeitemname$ : Repository<$entityName$>, I$entityName$Repository
    {
        // TODO: Match Database Context Interface type
        private readonly IDatabaseContext _context;

        // TODO: Match Database Context Interface type
        public $safeitemname$(IDatabaseContext context) : 
            base(context as DbContext)
        {
            _context = context;
        }

        public async Task<IEnumerable<$entityName$>> Get$entitySetName$()
        {
            // TODO: Add Includes for related entities if needed
            IEnumerable<$entityName$> entities = await _context.$entitySetName$
                .ToListAsync();
            return entities;
        }

        public async Task<$entityName$> Get$entityName$(int id)
        {
            // TODO: Add Includes for related entities if needed
            $entityName$ entity = await _context.$entitySetName$
                 .SingleOrDefaultAsync(t => t.$entityName$Id == id);
            return entity;
        }

        public async Task<bool> Delete$entityName$(int id)
        {
            $entityName$ entity = await Get$entityName$(id);
            if (entity == null) return false;
            Set.Attach(entity);
            Set.Remove(entity);

            // TODO: Remove child entities
            return true;
        }
        
        // TODO: Add methods to load related entities if needed
    }
}