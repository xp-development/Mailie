﻿using Mailie.DataAccessLayer;
using Mailie.Events;
using Mailie.Mvvm;

namespace Mailie.Views.MailAccounts
{
  public class MailAccountOverviewViewModel : OverviewViewModel<MailAccount, MailAccountView>
  {
    public MailAccountOverviewViewModel(IUnitOfWork unitOfWork, IEventAggregator eventAggregator)
      : base(unitOfWork, eventAggregator)
    {
    }
  }
}