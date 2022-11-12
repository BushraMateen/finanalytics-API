﻿using AutoMapper;
using FinCalculator.Application.Features.Porfolioes.Commands.CreatePortfolio;
using FinCalculator.Application.Features.Porfolioes.Queries.GetPortfolioDetails;
using FinCalculator.Application.Features.Porfolioes.Queries.GetPortfolioList;
using FinCalculator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinCalculator.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Portfolio, PortfolioListVm>().ReverseMap();
            CreateMap<Portfolio, PortfolioDetailVm>().ReverseMap();
           
            CreateMap<Portfolio, CreatePortfolioCommand>().ReverseMap();
           // CreateMap<Portfolio, UpdatePortfolioCommand>().ReverseMap();
           // CreateMap<Portfolio, DeletePortfolioCommand>().ReverseMap();

        }
    }
}
