using System.Collections.Generic;

namespace Tradovate.Services.Cache
{
    class EntityCacheSpecs
    {
        private Dictionary<string, EntityCacheSpec> Specs = new Dictionary<string, EntityCacheSpec>();

        public EntityCacheSpecs()
        {
            Specs["command"] = new EntityCacheSpec(true, "orderId", true);
            Specs["commandReport"] = new EntityCacheSpec(true, "commandId", true);
            Specs["executionReport"] = new EntityCacheSpec(true, "commandId", true);
            Specs["fill"] = new EntityCacheSpec(true, "orderId", true);
            Specs["orderVersion"] = new EntityCacheSpec(true, "orderId", true);
            Specs["tradingPermission"] = new EntityCacheSpec(false, "userId", true);
        }

        public EntityCacheSpec this[string entityType]
        {
            get
            {
                EntityCacheSpec result;
                if (Specs.TryGetValue(entityType, out result))
                {
                    return result;
                }
                return new EntityCacheSpec(false, null, false);
            }
        }
    }
}
