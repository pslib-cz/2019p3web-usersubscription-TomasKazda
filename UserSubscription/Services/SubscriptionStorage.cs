using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserSubscription.Models;

namespace UserSubscription.Services
{
    public class SubscriptionStorage : ISubscriptionStorage
    {
        private IRandomStringGenerator _rsg;
        public SubscriptionStorage(IRandomStringGenerator rsg)
        {
            _rsg = rsg;
        }

        public List<Subscription> Subscriptions { get; set; } = new List<Subscription>();

        public void Add(Subscription subscription)
        {
            
            subscription.Confirmed = false;
            subscription.ConfirmationCode = _rsg.Next(10);
            Subscriptions.Add(subscription);
        }
    }
}
