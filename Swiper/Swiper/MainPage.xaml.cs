using Swiper.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Swiper
{
    public partial class MainPage : ContentPage
    {
        private int _likeCount;
        private int _denyCount;
        public MainPage()
        {
            InitializeComponent();
            AddInitialPhotos();
            MainGrid.Children.Add(new SwiperControl());
        }



        private void AddInitialPhotos()
        {
            for (int i = 0; i < 10; i++)
            {
                InsertPhoto();
            }
            
        }

        private void InsertPhoto()
        {
            var photo = new SwiperControl();
            photo.OnDeny += Handle_OnDeny;
            photo.Onlike += Handle_OnLike;
            this.MainGrid.Children.Insert(0, photo);
        }

        private void UpdateGui()
        { 
            likeLabel.Text = _likeCount.ToString();
            denyLabel.Text = _denyCount.ToString();
        }
        private void Handle_OnLike(object sender, EventArgs e)
        {
            _likeCount++;
            InsertPhoto();
            UpdateGui();
        }
        private void Handle_OnDeny(object sender, EventArgs e)
        {
            _denyCount++;
            InsertPhoto();
            UpdateGui();
        }
    }
}
