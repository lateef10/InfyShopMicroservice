using AutoMapper;
using InfyShop.CouponAPI.Models;
using InfyShop.CouponAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfyShop.CouponAPI.ObjectMapper
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
