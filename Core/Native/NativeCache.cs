﻿#if MORPEH_BURST
namespace Morpeh.Native {
    using Morpeh;
    using Unity.Collections.LowLevel.Unsafe;

    public struct NativeCache<TNative> where TNative : unmanaged, IComponent {
        [NativeDisableUnsafePtrRestriction]
        public NativeIntHashMap<TNative> components;
    }
}
#endif