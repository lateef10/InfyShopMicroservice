﻿using AutoMapper;
using InfyShop.CouponAPI.DbContexts;
using InfyShop.CouponAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfyShop.CouponAPI.Respository
{
    public class CouponRepository : ICouponRepository
    {
        private readonly ApplicationDbContext _db;
        protected IMapper _mapper;
        public CouponRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<CouponDto> GetCouponByCode(string couponCode)
        {
            var couponFromDb = await _db.Coupons.FirstOrDefaultAsync(u => u.CouponCode == couponCode);
            return _mapper.Map<CouponDto>(couponFromDb);
        }
    }
}
