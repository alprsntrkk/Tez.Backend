using Autofac;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.AutoFac
{
    public class AutoFacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDAL>().As<IUserDAL>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            builder.RegisterType<CozumManager>().As<ICozumService>();
            builder.RegisterType<CozumDAL>().As<ICozumDAL>();

            builder.RegisterType<CozumPuanManager>().As<ICozumPuanService>();
            builder.RegisterType<CozumPuanDAL>().As<ICozumPuanDAL>();

            builder.RegisterType<EtkinlikManager>().As<IEtkinlikService>();
            builder.RegisterType<EtkinlikDAL>().As<IEtkinlikDAL>();

            builder.RegisterType<EtkinlikKatilimManager>().As<IEtkinlikKatilimService>();
            builder.RegisterType<EtkinlikKatilimDAL>().As<IEtkinlikKatilimDAL>();

            builder.RegisterType<HataManager>().As<IHataService>();
            builder.RegisterType<HataDAL>().As<IHataDAL>();

            builder.RegisterType<IlanManager>().As<IilanService>();
            builder.RegisterType<IlanDAL>().As<IilanDAL>();

            builder.RegisterType<IlanBasvuruManager>().As<IilanBasvuruService>();
            builder.RegisterType<IlanBasvuruDAL>().As<IilanBasvuruDAL>();


        }
    }
}
