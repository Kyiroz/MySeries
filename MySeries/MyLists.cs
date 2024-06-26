﻿using MySeries.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySeries
{
    public partial class MyLists : Form
    {
        public MyLists()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Book_Click(object sender, EventArgs e)
        {

        }

        private void MyLists_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < MySeries.MyTVList.getList().Count ; i++)
            {
                var index = dataGridView1.Rows.Add();

                Artwork series = MySeries.MyTVList.getList()[i];

                dataGridView1.Rows[index].Cells[0].Value = series.Title;
                dataGridView1.Rows[index].Cells[1].Value = series.Author;
                dataGridView1.Rows[index].Cells[2].Value = series.Date;
                dataGridView1.Rows[index].Cells[3].Value = series.Genre;
                dataGridView1.Rows[index].Cells[4].Value = series.Rating;
            }

            for (int i = 0; i < MySeries.MyAnimeList.getList().Count; i++)
            {
                var index = dataGridView2.Rows.Add();

                Artwork series = MySeries.MyAnimeList.getList()[i];

                dataGridView2.Rows[index].Cells[0].Value = series.Title;
                dataGridView2.Rows[index].Cells[1].Value = series.Author;
                dataGridView2.Rows[index].Cells[2].Value = series.Date;
                dataGridView2.Rows[index].Cells[3].Value = series.Genre;
                dataGridView2.Rows[index].Cells[4].Value = series.Rating;
            }

            for (int i = 0; i < MySeries.MyBookList.getList().Count; i++)
            {
                var index = dataGridView3.Rows.Add();

                Artwork series = MySeries.MyBookList.getList()[i];

                dataGridView3.Rows[index].Cells[0].Value = series.Title;
                dataGridView3.Rows[index].Cells[1].Value = series.Author;
                dataGridView3.Rows[index].Cells[2].Value = series.Date;
                dataGridView3.Rows[index].Cells[3].Value = series.Genre;
                dataGridView3.Rows[index].Cells[4].Value = series.Rating;
            }

            for (int i = 0; i < MySeries.MyComicList.getList().Count; i++)
            {
                var index = dataGridView4.Rows.Add();

                Artwork series = MySeries.MyComicList.getList()[i];

                dataGridView4.Rows[index].Cells[0].Value = series.Title;
                dataGridView4.Rows[index].Cells[1].Value = series.Author;
                dataGridView4.Rows[index].Cells[2].Value = series.Date;
                dataGridView4.Rows[index].Cells[3].Value = series.Genre;
                dataGridView4.Rows[index].Cells[4].Value = series.Rating;
            }

            for (int i = 0; i < MySeries.MyMangaList.getList().Count; i++)
            {
                var index = dataGridView5.Rows.Add();

                Artwork series = MySeries.MyMangaList.getList()[i];

                dataGridView5.Rows[index].Cells[0].Value = series.Title;
                dataGridView5.Rows[index].Cells[1].Value = series.Author;
                dataGridView5.Rows[index].Cells[2].Value = series.Date;
                dataGridView5.Rows[index].Cells[3].Value = series.Genre;
                dataGridView5.Rows[index].Cells[4].Value = series.Rating;
            }

            for (int i = 0; i < MySeries.MyGameList.getList().Count; i++)
            {
                var index = dataGridView6.Rows.Add();

                Artwork series = MySeries.MyGameList.getList()[i];

                dataGridView6.Rows[index].Cells[0].Value = series.Title;
                dataGridView6.Rows[index].Cells[1].Value = series.Author;
                dataGridView6.Rows[index].Cells[2].Value = series.Date;
                dataGridView6.Rows[index].Cells[3].Value = series.Genre;
                dataGridView6.Rows[index].Cells[4].Value = series.Rating;
            }
        }
    }
}
