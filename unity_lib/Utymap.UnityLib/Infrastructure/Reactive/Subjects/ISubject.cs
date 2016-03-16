﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Utymap.UnityLib.Infrastructure.Reactive
{
    public interface ISubject<TSource, TResult> : IObserver<TSource>, IObservable<TResult>
    {
    }

    public interface ISubject<T> : ISubject<T, T>, IObserver<T>, IObservable<T>
    {
    }
}