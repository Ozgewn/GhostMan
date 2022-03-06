﻿using BL.query;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UI.ViewModels.Utilities;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace UI.Views
{
    public sealed partial class DefaultModes : Page
    {
        public DefaultModes()
        {
            this.InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        /// <summary>
        /// This method decides where to navigate depending on the name of the pressed button
        /// </summary>
        /// <param name="sender">Pressed button</param>
        /// <param name="e"></param>
        private void NavigateToPlay(object sender, RoutedEventArgs e)
        {
            var buttonPressed = sender as Button;
            switch (buttonPressed.Name)
            {
                case "btnEasy":
                    //Frame.Navigate(typeof(Prueba));
                    break;
                case "btnMedium":
                    //Frame.Navigate(typeof(PruebaMedio));
                    break;
                case "btnHard":
                    SharedData.AllImageSourceOfSprites = fromByteToImageConverter.convertirByteImagen(clsElementTypeQueryBL.getAllSpritesBL());
                    SharedData.MapSelectedToPlay = clsElementMapQueryBL.getElementMapOfDefaultHardMap();
                    SharedData.IsCommunityMap = false;
                    this.Frame.Navigate(typeof(Play));
                    break;
            }
        }
    }
}
