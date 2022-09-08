namespace Common.Mapper
{
    public static class ObjectExtensions
    {
        public static TTo MapTo<TTo>(this object source) where TTo : class
        {
            return AutoMapper.Mapper.Map<TTo>(source);
        }
    }
}