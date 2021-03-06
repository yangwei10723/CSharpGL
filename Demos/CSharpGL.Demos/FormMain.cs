﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CSharpGL.Demos
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/bitzhuwei/CSharpGL.Data");
        }

        private void btn00GLCanvas_Click(object sender, EventArgs e)
        {
            (new Form00GLCanvas()).Show();
        }

        private void btn02OrderIndependentTransparency_Click(object sender, EventArgs e)
        {
            (new Form02OrderIndependentTransparency()).Show();
        }

        private void btn06ImageProcessing_Click(object sender, EventArgs e)
        {
            (new Form06ImageProcessing()).Show();
        }

        private void btn07PointSprite_Click(object sender, EventArgs e)
        {
            (new Form07PointSprite()).Show();
        }

        private void btn11IFontTexture_Click(object sender, EventArgs e)
        {
            (new Form11IFontTexture()).Show();
        }

        private void btn12Billboard_Click(object sender, EventArgs e)
        {
            (new Form12Billboard()).Show();
        }

        private void btn15UIRenderer_Click(object sender, EventArgs e)
        {
            (new Form15UIRenderer()).Show();
        }

        private void btn16ArcBallManipulater_Click(object sender, EventArgs e)
        {
            (new Form16ArcBallManipulater()).Show();
        }

        private void btn18PickingInScene_Click(object sender, EventArgs e)
        {
            (new Form18PickingInScene()).Show();
        }

        private void btn20GLSceneCanvas_Click(object sender, EventArgs e)
        {
            (new Form20GLSceneCanvas()).Show();
        }

        private void btn21ConditionalRendering_Click(object sender, EventArgs e)
        {
            (new Form21ConditionalRendering()).Show();
        }

        private void btn23SingleRenderer_Click(object sender, EventArgs e)
        {
            (new Form23SingleRenderer()).Show();
        }

        private void btn25reyFilter_Click(object sender, EventArgs e)
        {
            (new Form25GreyFilter()).Show();
        }

        private void btn26DirectionalLight_Click(object sender, EventArgs e)
        {
            (new Form26DirectionalLight()).Show();
        }

        private void btn27PointLight_Click(object sender, EventArgs e)
        {
            (new Form27PointLight()).Show();
        }

        private void btn28SemisphereLighting_Click(object sender, EventArgs e)
        {
            (new Form28HemisphereLighting()).Show();
        }

        private void btn29FixedSize_Click(object sender, EventArgs e)
        {
            (new Form29FixedPercent()).Show();
        }

    }
}