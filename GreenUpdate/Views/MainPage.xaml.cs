﻿using GreenUpdate.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace GreenUpdate.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
