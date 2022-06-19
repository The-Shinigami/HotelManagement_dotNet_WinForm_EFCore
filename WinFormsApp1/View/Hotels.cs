using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;
using WinFormsApp1.View;

namespace WinFormsApp1
{
    public partial class Hotels : Form
    {
        
        string[] positions = new string[3] {"left", "main", "right" };
        List<Hotel> hotels = new List<Hotel> ();
        int iL = 0;
        int iM = 1;
        int iR = 2;
        
        HotelController hotelController = new HotelController ();

    public Hotels()
        {
            InitializeComponent();
            getData();
            loadDataToCards();
            this.CardNum.Text = (this.iM + 1) + "/" + this.hotels.Count();

        }

        public void getData()
        {
            this.hotels = hotelController.getHotels();
        }
        public void loadDataToCards()
        {

            LoadDataToMain();
            LoadDataToLeft();
            LoadDataToRight();

        }
       public void LoadDataToMain()
        {
            if (positions[1] == "main")
            {
                this.mainCity.Text = this.hotels[iM].Adresse.Ville;
                this.mainCountry.Text = this.hotels[iM].Adresse.Pays;
                this.mainStars.Text = "";
                for (int i=0;i< this.hotels[iM].Classement.Etoile; i++)   
                this.mainStars.Text += "★";
                this.mainStars.ForeColor = Color.Gold;
                this.mainLargePic.ImageLocation = this.hotels[iM].HotelImages[0].Src;
                this.mainSmallPic1.ImageLocation = this.hotels[iM].HotelImages[0].Src;
                this.mainSmallPic2.ImageLocation = this.hotels[iM].HotelImages[1].Src;
                this.mainSmallPic3.ImageLocation = this.hotels[iM].HotelImages[2].Src;
            }
            if (positions[1] == "left")
            {
                this.leftCity.Text = this.hotels[iM].Adresse.Ville;
                this.leftCountry.Text = this.hotels[iM].Adresse.Pays;
                this.leftStars.Text = "";
                for (int i = 0; i < this.hotels[iM].Classement.Etoile; i++)
                    this.leftStars.Text += "★";
                this.leftStars.ForeColor = Color.Gold;
                this.leftLargePic.ImageLocation = this.hotels[iM].HotelImages[0].Src;
                this.leftSmallPic1.ImageLocation = this.hotels[iM].HotelImages[0].Src;
                this.leftSmallPic2.ImageLocation = this.hotels[iM].HotelImages[1].Src;
                this.leftSmallPic3.ImageLocation = this.hotels[iM].HotelImages[2].Src;
            }
            if (positions[1] == "right")
            {
                this.rightCity.Text = this.hotels[iM].Adresse.Ville;
                this.rightCountry.Text = this.hotels[iM].Adresse.Pays;
                this.rightStars.Text = "";
                for (int i = 0; i < this.hotels[iM].Classement.Etoile; i++)
                    this.rightStars.Text += "★";
                this.rightStars.ForeColor = Color.Gold;
                this.rightLargePic.ImageLocation = this.hotels[iM].HotelImages[0].Src;
                this.rightSmallPic1.ImageLocation = this.hotels[iM].HotelImages[0].Src;
                this.rightSmallPic2.ImageLocation = this.hotels[iM].HotelImages[1].Src;
                this.rightSmallPic3.ImageLocation = this.hotels[iM].HotelImages[2].Src;
            }
        }
        public void LoadDataToLeft()
        {
            if (positions[0] == "main")
            {
                this.mainCity.Text = this.hotels[iL].Adresse.Ville;
                this.mainCountry.Text = this.hotels[iL].Adresse.Pays;
                this.mainStars.Text = "";
                for (int i = 0; i < this.hotels[iL].Classement.Etoile; i++)
                    this.mainStars.Text += "★";
                this.mainStars.ForeColor = Color.Gold;
                this.mainLargePic.ImageLocation = this.hotels[iL].HotelImages[0].Src;
                this.mainSmallPic1.ImageLocation = this.hotels[iL].HotelImages[0].Src;
                this.mainSmallPic2.ImageLocation = this.hotels[iL].HotelImages[1].Src;
                this.mainSmallPic3.ImageLocation = this.hotels[iL].HotelImages[2].Src;
            }
            if (positions[0] == "left")
            {
                this.leftCity.Text = this.hotels[iL].Adresse.Ville;
                this.leftCountry.Text = this.hotels[iL].Adresse.Pays;
                this.leftStars.Text = "";
                for (int i = 0; i < this.hotels[iL].Classement.Etoile; i++)
                    this.leftStars.Text += "★";
                this.leftStars.ForeColor = Color.Gold;
                this.leftLargePic.ImageLocation = this.hotels[iL].HotelImages[0].Src;
                this.leftSmallPic1.ImageLocation = this.hotels[iL].HotelImages[0].Src;
                this.leftSmallPic2.ImageLocation = this.hotels[iL].HotelImages[1].Src;
                this.leftSmallPic3.ImageLocation = this.hotels[iL].HotelImages[2].Src;
            }
            if (positions[0] == "right")
            {
                this.rightCity.Text = this.hotels[iL].Adresse.Ville;
                this.rightCountry.Text = this.hotels[iL].Adresse.Pays;
                this.rightStars.Text = "";
                for (int i = 0; i < this.hotels[iL].Classement.Etoile; i++)
                    this.rightStars.Text += "★";
                this.rightStars.ForeColor = Color.Gold;
                this.rightLargePic.ImageLocation = this.hotels[iL].HotelImages[0].Src;
                this.rightSmallPic1.ImageLocation = this.hotels[iL].HotelImages[0].Src;
                this.rightSmallPic2.ImageLocation = this.hotels[iL].HotelImages[1].Src;
                this.rightSmallPic3.ImageLocation = this.hotels[iL].HotelImages[2].Src;
            }
        }
        public void LoadDataToRight()
        {
            if (positions[2] == "main")
            {
                this.mainCity.Text = this.hotels[iR].Adresse.Ville;
                this.mainCountry.Text = this.hotels[iR].Adresse.Pays;
                this.mainStars.Text = "";
                for (int i = 0; i < this.hotels[iR].Classement.Etoile; i++)
                    this.mainStars.Text += "★";
                this.mainStars.ForeColor = Color.Gold;
                this.mainLargePic.ImageLocation = this.hotels[iR].HotelImages[0].Src;
                this.mainSmallPic1.ImageLocation = this.hotels[iR].HotelImages[0].Src;
                this.mainSmallPic2.ImageLocation = this.hotels[iR].HotelImages[1].Src;
                this.mainSmallPic3.ImageLocation = this.hotels[iR].HotelImages[2].Src;
            }
            if (positions[2] == "left")
            {
                this.leftCity.Text = this.hotels[iR].Adresse.Ville;
                this.leftCountry.Text = this.hotels[iR].Adresse.Pays;
                this.leftStars.Text = "";
                for (int i = 0; i < this.hotels[iR].Classement.Etoile; i++)
                    this.leftStars.Text += "★";
                this.leftStars.ForeColor = Color.Gold;
                this.leftLargePic.ImageLocation = this.hotels[iR].HotelImages[0].Src;
                this.leftSmallPic1.ImageLocation = this.hotels[iR].HotelImages[0].Src;
                this.leftSmallPic2.ImageLocation = this.hotels[iR].HotelImages[1].Src;
                this.leftSmallPic3.ImageLocation = this.hotels[iR].HotelImages[2].Src;
            }
            if (positions[2] == "right")
            {
                this.rightCity.Text = this.hotels[iR].Adresse.Ville;
                this.rightCountry.Text = this.hotels[iR].Adresse.Pays;
                this.rightStars.Text = "";
                for (int i = 0; i < this.hotels[iR].Classement.Etoile; i++)
                    this.rightStars.Text += "★";
                this.rightStars.ForeColor = Color.Gold;
                this.rightLargePic.ImageLocation = this.hotels[iR].HotelImages[0].Src;
                this.rightSmallPic1.ImageLocation = this.hotels[iR].HotelImages[0].Src;
                this.rightSmallPic2.ImageLocation = this.hotels[iR].HotelImages[1].Src;
                this.rightSmallPic3.ImageLocation = this.hotels[iR].HotelImages[2].Src;
            }
        }
        
        
       

      private void pictureBox2_Click(object sender, EventArgs e)
        { toLeft();

            if (iL == 0)
            {
                iL = this.hotels.Count() - 1;
            }
            else
            { iL--; }
            if (iR == 0)
            { iR = this.hotels.Count() - 1; }
            else
            { iR--; }
            if (iM == 0)
            { iM = this.hotels.Count() - 1; }
            else
            { iM--; }
            this.loadDataToCards();
            this.CardNum.Text = (this.iM + 1) + "/" + this.hotels.Count();
        }
      private void pictureBox3_Click(object sender, EventArgs e)
        { 
            toRight();

            if (iL == this.hotels.Count() - 1)
            {iL = 0;}
            else
            { iL++; }
            if (iR == this.hotels.Count() - 1)
            { iR = 0; }
            else
            { iR++; }
            if (iM == this.hotels.Count() - 1)
            { iM = 0; }
            else
            { iM++; }
            this.loadDataToCards();
            this.CardNum.Text = (this.iM + 1) + "/" + this.hotels.Count();
        }

        public void toLeft()
        {
            swipToLeft();

            if (positions[2] == "main")
            {
                toSmall("main");
                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(mainFram, "Top", 133);
                t.add(mainFram, "Left", 589);
                t.run();

                
            }
            if (positions[2] == "left")
            {

                toSmall("left");
                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(leftFram, "Top", 133);
                t.add(leftFram, "Left", 589);
                t.run();
            }
            if (positions[2] == "right")
            {

                toSmall("right");
                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(rightFram, "Top", 133);
                t.add(rightFram, "Left", 589);
                t.run();
            }


            if (positions[1] == "left")
            {
                leftFram.BringToFront();
                Transition t2 = new Transition(new TransitionType_EaseInEaseOut(500));
                t2.add(leftFram, "Top", 101);
                t2.add(leftFram, "Left", 249);
                t2.run();
                t2.TransitionCompletedEvent += toLarge;
            }
            if (positions[1] == "main")
            {
                mainFram.BringToFront();
                Transition t2 = new Transition(new TransitionType_EaseInEaseOut(500));
                t2.add(mainFram, "Top", 101);
                t2.add(mainFram, "Left", 249);
                t2.run();
                t2.TransitionCompletedEvent += toLarge;
            }
            if (positions[1] == "right")
            {
                rightFram.BringToFront();
                Transition t2 = new Transition(new TransitionType_EaseInEaseOut(500));
                t2.add(rightFram, "Top", 101);
                t2.add(rightFram, "Left", 249);
                t2.run();
                t2.TransitionCompletedEvent += toLarge;
            }



            if (positions[0] == "left")
            {
                leftFram.SendToBack();
                Transition t1 = new Transition(new TransitionType_EaseInEaseOut(400));
                t1.add(leftFram, "Left", 820);

                Transition t2 = new Transition(new TransitionType_EaseInEaseOut(1));
                t2.add(leftFram, "Top", 133);
                t2.add(leftFram, "Left", -40);


                //
                rightFram.SendToBack();
                Transition t3 = new Transition(new TransitionType_EaseInEaseOut(100));
                t3.add(leftFram, "Left", 26);


                Transition.runChain(t1, t2, t3);
            }
            if (positions[0] == "main")
            {
                mainFram.SendToBack();
                Transition t1 = new Transition(new TransitionType_EaseInEaseOut(400));
                t1.add(mainFram, "Left", 820);

                Transition t2 = new Transition(new TransitionType_EaseInEaseOut(1));
                t2.add(mainFram, "Top", 133);
                t2.add(mainFram, "Left", -40);

                //
                rightFram.SendToBack();
                Transition t3 = new Transition(new TransitionType_EaseInEaseOut(100));
                t3.add(mainFram, "Left", 26);


                Transition.runChain(t1, t2, t3);


            }
            if (positions[0] == "right")
            {
                rightFram.SendToBack();
                Transition t1 = new Transition(new TransitionType_EaseInEaseOut(400));

                t1.add(rightFram, "Left", 820);

                Transition t2 = new Transition(new TransitionType_EaseInEaseOut(1));
                t2.add(rightFram, "Top", 133);
                t2.add(rightFram, "Left", -40);
               
                //
                rightFram.SendToBack();
                Transition t3 = new Transition(new TransitionType_EaseInEaseOut(100));
                t3.add(rightFram, "Left", 26);


                Transition.runChain(t1, t2, t3);
            }



        }

        
        public void swipToLeft()
        {
            string tmp = positions[2];
            positions[2] = positions[1];
            positions[1] = positions[0];
            positions[0] = tmp;

        }
        public void swipToRight()
        {
            string tmp = positions[0];
            positions[0] = positions[1];
            positions[1] = positions[2];
            positions[2] = tmp;

        }

        public void toSmall(string fram)
        {
            if (fram == "main")
            {
                this.mainFram.Visible = false;
                //frame
                this.mainFram.Size = new System.Drawing.Size(200, 192);
                //city
                this.mainCity.Size = new System.Drawing.Size(30, 12);
                this.mainCity.Location = new System.Drawing.Point(151, 114);
                this.mainCity.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.GraphicsUnit.Point);
                //city label
                this.mainCityLabel.Size = new System.Drawing.Size(23, 12);
                this.mainCityLabel.Location = new System.Drawing.Point(122, 114);
                this.mainCityLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //see more button
                this.mainSeeMoreButton.Size = new System.Drawing.Size(71, 24);
                this.mainSeeMoreButton.Location = new System.Drawing.Point(74, 157);
                this.mainSeeMoreButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //stars
                this.mainStars.Size = new System.Drawing.Size(80, 27);
                this.mainStars.Location = new System.Drawing.Point(73, 130);
                this.mainStars.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.GraphicsUnit.Point);
                //stars label
                this.mainStarsLabel.Size = new System.Drawing.Size(28, 12);
                this.mainStarsLabel.Location = new System.Drawing.Point(18, 134);
                this.mainStarsLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //country
                this.mainCountry.Size = new System.Drawing.Size(43, 12);
                this.mainCountry.Location = new System.Drawing.Point(73, 114);
                this.mainCountry.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.GraphicsUnit.Point);
                //country label
                this.mainCountryLabel.Size = new System.Drawing.Size(42, 12);
                this.mainCountryLabel.Location = new System.Drawing.Point(18, 114);
                this.mainCountryLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //large pic
                this.mainLargePic.Size = new System.Drawing.Size(136, 95);
                this.mainLargePic.Location = new System.Drawing.Point(9, 7);
                //small pic 3
                this.mainSmallPic3.Size = new System.Drawing.Size(39, 28);
                this.mainSmallPic3.Location = new System.Drawing.Point(151, 74);
                //small pic 2
                this.mainSmallPic2.Size = new System.Drawing.Size(39, 30);
                this.mainSmallPic2.Location = new System.Drawing.Point(151, 38);
                //small pic 1
                this.mainSmallPic1.Size = new System.Drawing.Size(39, 25);
                this.mainSmallPic1.Location = new System.Drawing.Point(151, 7);
                this.mainFram.Visible = true;
            }
            if (fram == "left")
            {
                this.leftFram.Visible = false;
                //frame
                this.leftFram.Size = new System.Drawing.Size(200, 192);
                //city
                this.leftCity.Size = new System.Drawing.Size(30, 12);
                this.leftCity.Location = new System.Drawing.Point(151, 114);
                this.leftCity.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.GraphicsUnit.Point);
                //city label
                this.leftCityLabel.Size = new System.Drawing.Size(23, 12);
                this.leftCityLabel.Location = new System.Drawing.Point(122, 114);
                this.leftCityLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //see more button
                this.leftSeeMoreButton.Size = new System.Drawing.Size(71, 24);
                this.leftSeeMoreButton.Location = new System.Drawing.Point(74, 157);
                this.leftSeeMoreButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //stars
                this.leftStars.Size = new System.Drawing.Size(80, 27);
                this.leftStars.Location = new System.Drawing.Point(73, 130);
                this.leftStars.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.GraphicsUnit.Point);
                //stars label
                this.leftStarsLabel.Size = new System.Drawing.Size(28, 12);
                this.leftStarsLabel.Location = new System.Drawing.Point(18, 134);
                this.leftStarsLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //country
                this.leftCountry.Size = new System.Drawing.Size(43, 12);
                this.leftCountry.Location = new System.Drawing.Point(73, 114);
                this.leftCountry.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.GraphicsUnit.Point);
                //country label
                this.leftCountryLabel.Size = new System.Drawing.Size(42, 12);
                this.leftCountryLabel.Location = new System.Drawing.Point(18, 114);
                this.leftCountryLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //large pic
                this.leftLargePic.Size = new System.Drawing.Size(136, 95);
                this.leftLargePic.Location = new System.Drawing.Point(9, 7);
                //small pic 3
                this.leftSmallPic3.Size = new System.Drawing.Size(39, 28);
                this.leftSmallPic3.Location = new System.Drawing.Point(151, 74);
                //small pic 2
                this.leftSmallPic2.Size = new System.Drawing.Size(39, 30);
                this.leftSmallPic2.Location = new System.Drawing.Point(151, 38);
                //small pic 1
                this.leftSmallPic1.Size = new System.Drawing.Size(39, 25);
                this.leftSmallPic1.Location = new System.Drawing.Point(151, 7);
                this.leftFram.Visible = true;
            }
            if (fram == "right")
            {
                this.rightFram.Visible = false;
                //frame
                this.rightFram.Size = new System.Drawing.Size(200, 192);
                //city
                this.rightCity.Size = new System.Drawing.Size(30, 12);
                this.rightCity.Location = new System.Drawing.Point(151, 114);
                this.rightCity.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.GraphicsUnit.Point);
                //city label
                this.rightCityLabel.Size = new System.Drawing.Size(23, 12);
                this.rightCityLabel.Location = new System.Drawing.Point(122, 114);
                this.rightCityLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //see more button
                this.rightSeeMoreButton.Size = new System.Drawing.Size(71, 24);
                this.rightSeeMoreButton.Location = new System.Drawing.Point(74, 157);
                this.rightSeeMoreButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //stars
                this.rightStars.Size = new System.Drawing.Size(80, 27);
                this.rightStars.Location = new System.Drawing.Point(73, 130);
                this.rightStars.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.GraphicsUnit.Point);
                //stars label
                this.rightStarsLabel.Size = new System.Drawing.Size(28, 12);
                this.rightStarsLabel.Location = new System.Drawing.Point(18, 134);
                this.rightStarsLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //country
                this.rightCountry.Size = new System.Drawing.Size(43, 12);
                this.rightCountry.Location = new System.Drawing.Point(73, 114);
                this.rightCountry.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.GraphicsUnit.Point);
                //country label
                this.rightCountryLabel.Size = new System.Drawing.Size(42, 12);
                this.rightCountryLabel.Location = new System.Drawing.Point(18, 114);
                this.rightCountryLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //large pic
                this.rightLargePic.Size = new System.Drawing.Size(136, 95);
                this.rightLargePic.Location = new System.Drawing.Point(9, 7);
                //small pic 3
                this.rightSmallPic3.Size = new System.Drawing.Size(39, 28);
                this.rightSmallPic3.Location = new System.Drawing.Point(151, 74);
                //small pic 2
                this.rightSmallPic2.Size = new System.Drawing.Size(39, 30);
                this.rightSmallPic2.Location = new System.Drawing.Point(151, 38);
                //small pic 1
                this.rightSmallPic1.Size = new System.Drawing.Size(39, 25);
                this.rightSmallPic1.Location = new System.Drawing.Point(151, 7);
                this.rightFram.Visible = true;
            }
        }
        private void toLarge(object sender,EventArgs e)
        {           
            if (positions[1] == "left")
            {
                this.leftFram.Visible = false;
                //frame
                this.leftFram.Size = new System.Drawing.Size(319, 274);
                //city
                this.leftCity.Size = new System.Drawing.Size(44, 19);
                this.leftCity.Location = new System.Drawing.Point(264, 167);
                this.leftCity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.GraphicsUnit.Point);
                //city label
                this.leftCityLabel.Size = new System.Drawing.Size(35, 19);
                this.leftCityLabel.Location = new System.Drawing.Point(212, 167);
                this.leftCityLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //see more button
                this.leftSeeMoreButton.Size = new System.Drawing.Size(100, 30);
                this.leftSeeMoreButton.Location = new System.Drawing.Point(123, 225);
                this.leftSeeMoreButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //stars
                this.leftStars.Size = new System.Drawing.Size(80, 27);
                this.leftStars.Location = new System.Drawing.Point(123, 189);
                this.leftStars.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.GraphicsUnit.Point);
                //stars label
                this.leftStarsLabel.Size = new System.Drawing.Size(42, 19);
                this.leftStarsLabel.Location = new System.Drawing.Point(41, 195);
                this.leftStarsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //country
                this.leftCountry.Size = new System.Drawing.Size(62, 19);
                this.leftCountry.Location = new System.Drawing.Point(123, 167);
                this.leftCountry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.GraphicsUnit.Point);
                //country label
                this.leftCountryLabel.Size = new System.Drawing.Size(63, 19);
                this.leftCountryLabel.Location = new System.Drawing.Point(41, 167);
                this.leftCountryLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //large pic
                this.leftLargePic.Size = new System.Drawing.Size(237, 142);
                this.leftLargePic.Location = new System.Drawing.Point(10, 9);
                //small pic 3
                this.leftSmallPic3.Size = new System.Drawing.Size(56, 40);
                this.leftSmallPic3.Location = new System.Drawing.Point(255, 111);
                //small pic 2
                this.leftSmallPic2.Size = new System.Drawing.Size(57, 40);
                this.leftSmallPic2.Location = new System.Drawing.Point(254, 60);
                //small pic 1
                this.leftSmallPic1.Size = new System.Drawing.Size(56, 40);
                this.leftSmallPic1.Location = new System.Drawing.Point(252, 14);
                this.leftFram.Visible = true;
            }
            if (positions[1] == "main")
            {
                this.mainFram.Visible = false;
                //frame
                this.mainFram.Size = new System.Drawing.Size(319, 274);
                //city
                this.mainCity.Size = new System.Drawing.Size(44, 19);
                this.mainCity.Location = new System.Drawing.Point(264, 167);
                this.mainCity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.GraphicsUnit.Point);
                //city label
                this.mainCityLabel.Size = new System.Drawing.Size(35, 19);
                this.mainCityLabel.Location = new System.Drawing.Point(212, 167);
                this.mainCityLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //see more button
                this.mainSeeMoreButton.Size = new System.Drawing.Size(100, 30);
                this.mainSeeMoreButton.Location = new System.Drawing.Point(123, 225);
                this.mainSeeMoreButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //stars
                this.mainStars.Size = new System.Drawing.Size(80, 27);
                this.mainStars.Location = new System.Drawing.Point(123, 189);
                this.mainStars.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.GraphicsUnit.Point);
                //stars label
                this.mainStarsLabel.Size = new System.Drawing.Size(42, 19);
                this.mainStarsLabel.Location = new System.Drawing.Point(41, 195);
                this.mainStarsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //country
                this.mainCountry.Size = new System.Drawing.Size(62, 19);
                this.mainCountry.Location = new System.Drawing.Point(123, 167);
                this.mainCountry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.GraphicsUnit.Point);
                //country label
                this.mainCountryLabel.Size = new System.Drawing.Size(63, 19);
                this.mainCountryLabel.Location = new System.Drawing.Point(41, 167);
                this.mainCountryLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //large pic
                this.mainLargePic.Size = new System.Drawing.Size(237, 142);
                this.mainLargePic.Location = new System.Drawing.Point(10, 9);
                //small pic 3
                this.mainSmallPic3.Size = new System.Drawing.Size(56, 40);
                this.mainSmallPic3.Location = new System.Drawing.Point(255, 111);
                //small pic 2
                this.mainSmallPic2.Size = new System.Drawing.Size(57, 40);
                this.mainSmallPic2.Location = new System.Drawing.Point(254, 60);
                //small pic 1
                this.mainSmallPic1.Size = new System.Drawing.Size(56, 40);
                this.mainSmallPic1.Location = new System.Drawing.Point(252, 14);
                this.mainFram.Visible = true;
            }
            if (positions[1] == "right")
            {
                this.rightFram.Visible = false;
                //frame
                this.rightFram.Size = new System.Drawing.Size(319, 274);
                //city
                this.rightCity.Size = new System.Drawing.Size(44, 19);
                this.rightCity.Location = new System.Drawing.Point(264, 167);
                this.rightCity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.GraphicsUnit.Point);
                //city label
                this.rightCityLabel.Size = new System.Drawing.Size(35, 19);
                this.rightCityLabel.Location = new System.Drawing.Point(212, 167);
                this.rightCityLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //see more button
                this.rightSeeMoreButton.Size = new System.Drawing.Size(100, 30);
                this.rightSeeMoreButton.Location = new System.Drawing.Point(123, 225);
                this.rightSeeMoreButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //stars
                this.rightStars.Size = new System.Drawing.Size(80, 27);
                this.rightStars.Location = new System.Drawing.Point(123, 189);
                this.rightStars.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.GraphicsUnit.Point);
                //stars label
                this.rightStarsLabel.Size = new System.Drawing.Size(42, 19);
                this.rightStarsLabel.Location = new System.Drawing.Point(41, 195);
                this.rightStarsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //country
                this.rightCountry.Size = new System.Drawing.Size(62, 19);
                this.rightCountry.Location = new System.Drawing.Point(123, 167);
                this.rightCountry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.GraphicsUnit.Point);
                //country label
                this.rightCountryLabel.Size = new System.Drawing.Size(63, 19);
                this.rightCountryLabel.Location = new System.Drawing.Point(41, 167);
                this.rightCountryLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                //large pic
                this.rightLargePic.Size = new System.Drawing.Size(237, 142);
                this.rightLargePic.Location = new System.Drawing.Point(10, 9);
                //small pic 3
                this.rightSmallPic3.Size = new System.Drawing.Size(56, 40);
                this.rightSmallPic3.Location = new System.Drawing.Point(255, 111);
                //small pic 2
                this.rightSmallPic2.Size = new System.Drawing.Size(57, 40);
                this.rightSmallPic2.Location = new System.Drawing.Point(254, 60);
                //small pic 1
                this.rightSmallPic1.Size = new System.Drawing.Size(56, 40);
                this.rightSmallPic1.Location = new System.Drawing.Point(252, 14);
                this.rightFram.Visible = true;
            }
        }
    
        
        

        
        public void toRight()
        {
            swipToRight();


            if (positions[0] == "main")
            {
                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(mainFram, "Top", 133);
                t.add(mainFram, "Left", 26);
                t.run();

                toSmall("main");
            }
            if (positions[0] == "left")
            {
                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(leftFram, "Top", 133);
                t.add(leftFram, "Left", 26);
                t.run();
                toSmall("left");
            }
            if (positions[0] == "right")
            {
                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(rightFram, "Top", 133);
                t.add(rightFram, "Left", 26);
                t.run();
                toSmall("right");
            }

            if (positions[1] == "right")
            {
                rightFram.BringToFront();
                Transition t2 = new Transition(new TransitionType_EaseInEaseOut(500));
                t2.add(rightFram, "Top", 101);
                t2.add(rightFram, "Left", 249);
                t2.run();
                t2.TransitionCompletedEvent += toLarge;
            }
            if (positions[1] == "left")
            {
                leftFram.BringToFront();
                Transition t2 = new Transition(new TransitionType_EaseInEaseOut(500));
                t2.add(leftFram, "Top", 101);
                t2.add(leftFram, "Left", 249);
                t2.run();
                t2.TransitionCompletedEvent += toLarge;
            }
            if (positions[1] == "main")
            {
                mainFram.BringToFront();
                Transition t2 = new Transition(new TransitionType_EaseInEaseOut(500));
                t2.add(mainFram, "Top", 101);
                t2.add(mainFram, "Left", 249);
                t2.run();
                t2.TransitionCompletedEvent += toLarge;
            }



            if (positions[2] == "left")
            {
                leftFram.SendToBack();
                Transition t1 = new Transition(new TransitionType_EaseInEaseOut(300));
                t1.add(leftFram, "Left", -195);

                Transition t2 = new Transition(new TransitionType_EaseInEaseOut(1));
                t2.add(leftFram, "Top", 133);
                t2.add(leftFram, "Left", 629);


                //
                rightFram.SendToBack();
                Transition t3 = new Transition(new TransitionType_EaseInEaseOut(300));
                t3.add(leftFram, "Left", 589);


                Transition.runChain(t1,t2, t3);
            }
            if (positions[2] == "main")
            {
                mainFram.SendToBack();
                Transition t1 = new Transition(new TransitionType_EaseInEaseOut(300));

                t1.add(mainFram, "Left", -195);

                Transition t2 = new Transition(new TransitionType_EaseInEaseOut(1));
                t2.add(mainFram, "Top", 133);
                t2.add(mainFram, "Left", 629);

                //
                rightFram.SendToBack();
                Transition t3 = new Transition(new TransitionType_EaseInEaseOut(300));
                t3.add(mainFram, "Left", 589);


                Transition.runChain(t1,t2, t3);


            }
            if (positions[2] == "right")
            {
                rightFram.SendToBack();
                Transition t1 = new Transition(new TransitionType_EaseInEaseOut(300));

                t1.add(rightFram, "Left", -195);

                Transition t2 = new Transition(new TransitionType_EaseInEaseOut(1));
                t2.add(rightFram, "Top", 133);
                t2.add(rightFram, "Left", 629);


                //
                rightFram.SendToBack();
                Transition t3 = new Transition(new TransitionType_EaseInEaseOut(300));
                t3.add(rightFram, "Left", 589);


                Transition.runChain(t1,t2, t3);
            }


        }
        private void leftLargePic_Click(object sender, EventArgs e)
        {

        }

        private void rightFram_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void mainFram_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainSeeMoreButton_Click(object sender, EventArgs e)
        {
            if (positions[0] == "main")
            {
                DetailsHotel u = new DetailsHotel(this.hotels[iL]);
                u.Show();
            }
            if (positions[1] == "main")
            {
                DetailsHotel u = new DetailsHotel(this.hotels[iM]);
                u.Show();
            }
            if (positions[2] == "main")
            {
                DetailsHotel u = new DetailsHotel(this.hotels[iR]);
                u.Show();
            }
        }

        private void mainSmallPic1_Click(object sender, EventArgs e)
        {
            mainLargePic.ImageLocation = this.hotels[iM].HotelImages[0].Src;
        }

        private void mainSmallPic2_Click(object sender, EventArgs e)
        {
            mainLargePic.ImageLocation = this.hotels[iM].HotelImages[1].Src;
        }

        private void mainSmallPic3_Click(object sender, EventArgs e)
        {
            mainLargePic.ImageLocation = this.hotels[iM].HotelImages[2].Src;
        }

        private void leftSmallPic1_Click(object sender, EventArgs e)
        {
            leftLargePic.ImageLocation = this.hotels[iL].HotelImages[0].Src;
        }

        private void leftSmallPic2_Click(object sender, EventArgs e)
        {
            leftLargePic.ImageLocation = this.hotels[iL].HotelImages[1].Src;
        }

        private void leftSmallPic3_Click(object sender, EventArgs e)
        {
            leftLargePic.ImageLocation = this.hotels[iL].HotelImages[2].Src;
        }

        private void rightSmallPic1_Click(object sender, EventArgs e)
        {
            rightLargePic.ImageLocation = this.hotels[iR].HotelImages[0].Src;
        }

        private void rightSmallPic2_Click(object sender, EventArgs e)
        {
            rightLargePic.ImageLocation = this.hotels[iR].HotelImages[1].Src;
        }

        private void rightSmallPic3_Click(object sender, EventArgs e)
        {
            rightLargePic.ImageLocation = this.hotels[iR].HotelImages[2].Src;
        }

        private void rightSeeMoreButton_Click(object sender, EventArgs e)
        {
            if (positions[0] == "right")
            {
                DetailsHotel u = new DetailsHotel(this.hotels[iL]);
                u.Show();
            }
            if (positions[1] == "right")
            {
                DetailsHotel u = new DetailsHotel(this.hotels[iM]);
                u.Show();
            }
            if (positions[2] == "right")
            {
                DetailsHotel u = new DetailsHotel(this.hotels[iR]);
                u.Show();
            }
        }

        private void leftSeeMoreButton_Click(object sender, EventArgs e)
        {
            if (positions[0] == "left")
            {
                DetailsHotel u = new DetailsHotel(this.hotels[iL]);
                u.Show();
            }
            if (positions[1] == "left")
            {
                DetailsHotel u = new DetailsHotel(this.hotels[iM]);
                u.Show();
            }
            if (positions[2] == "left")
            {
                DetailsHotel u = new DetailsHotel(this.hotels[iR]);
                u.Show();
            }
        }
    }


}
