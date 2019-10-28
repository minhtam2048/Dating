using System;
using AutoMapper;

namespace DatingApp.API.Helpers
{
    public static class AutoMapperCompatibilityExtensions
    {
        public static void ResolveUsing<TSource, TDestination, TMember, TResult>(this IMemberConfigurationExpression<TSource, TDestination, TMember>member, Func<TSource, TResult>resolver) => member.MapFrom((Func<TSource, TDestination, TResult>)((src, dest) => resolver(src)));
    }
}