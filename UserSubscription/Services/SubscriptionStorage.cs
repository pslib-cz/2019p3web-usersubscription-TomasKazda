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
        private SubscriptionContext _db;
        public SubscriptionStorage(IRandomStringGenerator rsg, SubscriptionContext db)
        {
            _rsg = rsg;
            _db = db;
        }

        public List<Subscription> Subscriptions
        {
            get
            {
                return _db.Subscriptions.ToList();
            }
            set
            {
                var temp = value;
            }
        }

        public void Add(Subscription subscription)
        {

            subscription.Confirmed = false;
            subscription.ConfirmationCode = _rsg.Next(10);

            _db.Subscriptions.Add(subscription);
            _db.SaveChanges();
        }
    }
}
