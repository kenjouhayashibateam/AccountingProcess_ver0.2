﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WPF.ViewModels.Commands
{
    public class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action _Execute;
        private readonly Func<bool> _CanExecute;

        public DelegateCommand(Action execute, Func<bool> canExecute)
        {
            _Execute = execute ?? throw new ArgumentNullException(nameof(DelegateCommand) + ":" + nameof(execute));
            _CanExecute = canExecute ?? throw new ArgumentNullException(nameof(DelegateCommand) + ":" + nameof(canExecute));
        }

        public bool CanExecute(object parameter)
        {
            return _CanExecute();
        }

        public bool CanExecute()
        {
            return _CanExecute();
        }

        public void Execute(object parameter)
        {
            _Execute();
        }

        public void Execute()
        {
            _Execute();
        }
    }
}
