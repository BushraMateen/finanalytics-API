using AutoMapper;
using FinCalculator.Application.Features.Porfolioes.Commands.CreatePortfolio;
using FinCalculator.Application.Features.Porfolioes.Queries.GetPortfolioDetails;
using FinCalculator.Application.Features.Porfolioes.Queries.GetPortfolioList;
using FinCalculator.Application.Features.Porfolioes.Commands.UpdatePortfolio;
using FinCalculator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using FinCalculator.Application.Features.Porfolioes.Queries.GetPortfolioInfo;

namespace FinCalculator.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Portfolio, PortfolioListVm>().ReverseMap();
            CreateMap<Portfolio, PortfolioDetailVm>().ReverseMap();
           
            CreateMap<Portfolio, CreatePortfolioCommand>().ReverseMap();
            CreateMap<Portfolio, UpdatePortfolioCommand>().ReverseMap();
            CreateMap<PortfolioDetail, PortfolioInfoVm>().ReverseMap();
            // CreateMap<Portfolio, DeletePortfolioCommand>().ReverseMap();

        }
    }
}
