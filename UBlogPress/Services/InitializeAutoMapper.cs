using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UBlogPress.Models;

namespace UBlogPress.Services
{
    public class InitializeAutoMapper
    {
        public static void Initialize()
        {
            CreateModelToViewModel();
            CreateViewModelToModel();
        }

        public static void CreateModelToViewModel()
        {
            Mapper.CreateMap<PostViewModel, Post>();
        }

        public static void CreateViewModelToModel()
        {
            Mapper.CreateMap<Post, PostViewModel>();
        }
    }
}