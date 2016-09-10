namespace RegistraPokemons
{
    partial class PokemonShow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokemonShow));
            this.btn_src = new System.Windows.Forms.Button();
            this.ptb_pokemon = new System.Windows.Forms.PictureBox();
            this.lbl_pokemon = new System.Windows.Forms.Label();
            this.lbl_nametext = new System.Windows.Forms.Label();
            this.lbl_idtext = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_niveltext = new System.Windows.Forms.Label();
            this.lbl_nivel = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_tipotext = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_pokeballs = new System.Windows.Forms.Label();
            this.lbl_coins = new System.Windows.Forms.Label();
            this.ptb_pokelogo = new System.Windows.Forms.PictureBox();
            this.txb_pokemon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_pokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_pokelogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_src
            // 
            this.btn_src.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_src.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_src.Font = new System.Drawing.Font("Racer", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_src.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_src.Location = new System.Drawing.Point(12, 388);
            this.btn_src.Name = "btn_src";
            this.btn_src.Size = new System.Drawing.Size(124, 38);
            this.btn_src.TabIndex = 1;
            this.btn_src.Text = "Buscar";
            this.btn_src.UseVisualStyleBackColor = false;
            this.btn_src.Click += new System.EventHandler(this.button1_Click);
            // 
            // ptb_pokemon
            // 
            this.ptb_pokemon.BackColor = System.Drawing.Color.Transparent;
            this.ptb_pokemon.Image = global::RegistraPokemons.Properties.Resources.Pokeball;
            this.ptb_pokemon.Location = new System.Drawing.Point(178, 183);
            this.ptb_pokemon.Name = "ptb_pokemon";
            this.ptb_pokemon.Size = new System.Drawing.Size(97, 98);
            this.ptb_pokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_pokemon.TabIndex = 3;
            this.ptb_pokemon.TabStop = false;
            // 
            // lbl_pokemon
            // 
            this.lbl_pokemon.AutoSize = true;
            this.lbl_pokemon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pokemon.Font = new System.Drawing.Font("Racer", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pokemon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_pokemon.Location = new System.Drawing.Point(18, 118);
            this.lbl_pokemon.Name = "lbl_pokemon";
            this.lbl_pokemon.Size = new System.Drawing.Size(76, 13);
            this.lbl_pokemon.TabIndex = 4;
            this.lbl_pokemon.Text = "Pokémon:";
            // 
            // lbl_nametext
            // 
            this.lbl_nametext.AutoSize = true;
            this.lbl_nametext.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nametext.Font = new System.Drawing.Font("Racer", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nametext.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_nametext.Location = new System.Drawing.Point(32, 142);
            this.lbl_nametext.Name = "lbl_nametext";
            this.lbl_nametext.Size = new System.Drawing.Size(9, 13);
            this.lbl_nametext.TabIndex = 5;
            this.lbl_nametext.Text = ".";
            // 
            // lbl_idtext
            // 
            this.lbl_idtext.AutoSize = true;
            this.lbl_idtext.BackColor = System.Drawing.Color.Transparent;
            this.lbl_idtext.Font = new System.Drawing.Font("Racer", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idtext.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_idtext.Location = new System.Drawing.Point(351, 302);
            this.lbl_idtext.Name = "lbl_idtext";
            this.lbl_idtext.Size = new System.Drawing.Size(9, 13);
            this.lbl_idtext.TabIndex = 7;
            this.lbl_idtext.Text = ".";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Racer", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_id.Location = new System.Drawing.Point(325, 302);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(20, 13);
            this.lbl_id.TabIndex = 6;
            this.lbl_id.Text = "ID:";
            // 
            // lbl_niveltext
            // 
            this.lbl_niveltext.AutoSize = true;
            this.lbl_niveltext.BackColor = System.Drawing.Color.Transparent;
            this.lbl_niveltext.Font = new System.Drawing.Font("Racer", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_niveltext.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_niveltext.Location = new System.Drawing.Point(351, 345);
            this.lbl_niveltext.Name = "lbl_niveltext";
            this.lbl_niveltext.Size = new System.Drawing.Size(9, 13);
            this.lbl_niveltext.TabIndex = 9;
            this.lbl_niveltext.Text = ".";
            // 
            // lbl_nivel
            // 
            this.lbl_nivel.AutoSize = true;
            this.lbl_nivel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nivel.Font = new System.Drawing.Font("Racer", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nivel.Location = new System.Drawing.Point(296, 345);
            this.lbl_nivel.Name = "lbl_nivel";
            this.lbl_nivel.Size = new System.Drawing.Size(49, 13);
            this.lbl_nivel.TabIndex = 8;
            this.lbl_nivel.Text = "NIVEL:";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipo.Font = new System.Drawing.Font("Racer", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_tipo.Location = new System.Drawing.Point(307, 388);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(38, 13);
            this.lbl_tipo.TabIndex = 10;
            this.lbl_tipo.Text = "TIPO:";
            // 
            // lbl_tipotext
            // 
            this.lbl_tipotext.AutoSize = true;
            this.lbl_tipotext.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipotext.Font = new System.Drawing.Font("Racer", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipotext.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_tipotext.Location = new System.Drawing.Point(351, 388);
            this.lbl_tipotext.Name = "lbl_tipotext";
            this.lbl_tipotext.Size = new System.Drawing.Size(9, 13);
            this.lbl_tipotext.TabIndex = 11;
            this.lbl_tipotext.Text = ".";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RegistraPokemons.Properties.Resources.Pokeball;
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::RegistraPokemons.Properties.Resources.dollar;
            this.pictureBox2.Location = new System.Drawing.Point(2, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_pokeballs
            // 
            this.lbl_pokeballs.AutoSize = true;
            this.lbl_pokeballs.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pokeballs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pokeballs.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_pokeballs.Location = new System.Drawing.Point(32, 12);
            this.lbl_pokeballs.Name = "lbl_pokeballs";
            this.lbl_pokeballs.Size = new System.Drawing.Size(63, 15);
            this.lbl_pokeballs.TabIndex = 14;
            this.lbl_pokeballs.Text = "0000000";
            // 
            // lbl_coins
            // 
            this.lbl_coins.AutoSize = true;
            this.lbl_coins.BackColor = System.Drawing.Color.Transparent;
            this.lbl_coins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coins.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_coins.Location = new System.Drawing.Point(31, 55);
            this.lbl_coins.Name = "lbl_coins";
            this.lbl_coins.Size = new System.Drawing.Size(63, 15);
            this.lbl_coins.TabIndex = 15;
            this.lbl_coins.Text = "0000000";
            // 
            // ptb_pokelogo
            // 
            this.ptb_pokelogo.BackColor = System.Drawing.Color.Transparent;
            this.ptb_pokelogo.Image = global::RegistraPokemons.Properties.Resources.Pokemon;
            this.ptb_pokelogo.Location = new System.Drawing.Point(128, 12);
            this.ptb_pokelogo.Name = "ptb_pokelogo";
            this.ptb_pokelogo.Size = new System.Drawing.Size(195, 72);
            this.ptb_pokelogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_pokelogo.TabIndex = 16;
            this.ptb_pokelogo.TabStop = false;
            // 
            // txb_pokemon
            // 
            this.txb_pokemon.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txb_pokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_pokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_pokemon.Location = new System.Drawing.Point(142, 388);
            this.txb_pokemon.MaxLength = 3;
            this.txb_pokemon.Name = "txb_pokemon";
            this.txb_pokemon.Size = new System.Drawing.Size(102, 38);
            this.txb_pokemon.TabIndex = 17;
            this.txb_pokemon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_pokemon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_pokemon_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(139, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "# de Pokémon";
            // 
            // PokemonShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistraPokemons.Properties.Resources.pokedexia;
            this.ClientSize = new System.Drawing.Size(456, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_pokemon);
            this.Controls.Add(this.ptb_pokelogo);
            this.Controls.Add(this.lbl_coins);
            this.Controls.Add(this.lbl_pokeballs);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_tipotext);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.lbl_niveltext);
            this.Controls.Add(this.lbl_nivel);
            this.Controls.Add(this.lbl_idtext);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_nametext);
            this.Controls.Add(this.lbl_pokemon);
            this.Controls.Add(this.btn_src);
            this.Controls.Add(this.ptb_pokemon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PokemonShow";
            this.Text = "POKEDEX 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_pokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_pokelogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_src;
        private System.Windows.Forms.PictureBox ptb_pokemon;
        private System.Windows.Forms.Label lbl_pokemon;
        private System.Windows.Forms.Label lbl_nametext;
        private System.Windows.Forms.Label lbl_idtext;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_niveltext;
        private System.Windows.Forms.Label lbl_nivel;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_tipotext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_pokeballs;
        private System.Windows.Forms.Label lbl_coins;
        private System.Windows.Forms.PictureBox ptb_pokelogo;
        private System.Windows.Forms.TextBox txb_pokemon;
        private System.Windows.Forms.Label label1;
    }
}

