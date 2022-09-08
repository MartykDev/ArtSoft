
namespace Common.Mapper.Extensions
{
    public static class MapExtensions
    {
        public static TTo MapTo<TTo>(this object source) where TTo : class
            => AutoMapper.Mapper.Map<TTo>(source);

        public static IEnumerable<TTo> MapRangeTo<TTo>(this IEnumerable<object> source) where TTo : class
            => source.Select(x => x.MapTo<TTo>());
    }
}