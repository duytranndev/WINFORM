using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WFBuoi3
{
	class Internet
	{
		private int hour_begin;
		private int hour_end;
		private int minus_begin;
		private int minus_end;
		private int sum_time_minus;
		private int sum_time_hour;
		private double money;
		
		

		public Internet(int hour_begin, int hour_end, int minus_begin, int minus_end)
		{
			this.hour_begin = hour_begin;
			this.hour_end = hour_end;
			this.minus_begin = minus_begin;
			this.minus_end = minus_end;
			this.sum_time_minus = 0;
			this.sum_time_hour =0;
			this.money =0;
		}

		public int Hour_begin { get => hour_begin; set => hour_begin = value; }
		public int Hour_end { get => hour_end; set => hour_end = value; }
		public int Minus_begin { get => minus_begin; set => minus_begin = value; }
		public int Minus_end { get => minus_end; set => minus_end = value; }
		public int Sum_time_minus { get => sum_time_minus; set => sum_time_minus = value; }
		public int Sum_time_hour { get => sum_time_hour; set => sum_time_hour = value; }
		public double Money { get => money; set => money = value; }

		public void Get_money()
		{
			int temp_hour = 0, temp_minus = 0;
			double money_1, money_2, money_3;
			if (this.hour_begin < 7)
			{
				if (this.hour_end <= 7)
				{
					temp_hour = 6-this.hour_begin;
					temp_minus = 60 + this.minus_end - this.minus_begin;
					this.sum_time_hour = temp_hour + (int)temp_minus / 60;
					this.sum_time_minus = temp_minus % 60;
					money_1 = 300 * (temp_hour * 60 + temp_minus);
					this.money = money_1;
				}
				else if (this.hour_end <= 17)
				{
					temp_hour =7 - this.hour_begin;
					money_1 = 300 * (temp_hour * 60);
					this.sum_time_hour = temp_hour;
					temp_hour = this.hour_end - 7;
					this.sum_time_hour = this.sum_time_hour + temp_hour - 1;
					temp_minus = 60 + this.minus_end - this.minus_begin;
					this.sum_time_hour = this.sum_time_hour + (int)temp_minus / 60;
					this.sum_time_minus = temp_minus % 60;
					money_2 = 400 * (this.sum_time_hour * 60 + this.sum_time_minus);
					this.money = money_1 + money_2;
				}
				else
				{
					temp_hour = 7 - this.hour_begin;
					money_1 = 300 * (temp_hour * 60);
					money_2 = 400 * 10 * 60 * 0.9;
					this.sum_time_hour = temp_hour + 10;
					temp_hour = this.hour_end - 17;
					this.sum_time_hour = this.sum_time_hour + temp_hour - 1;
					temp_minus = 60 + this.minus_end - this.minus_begin;
					this.sum_time_hour = this.sum_time_hour + (int)temp_minus / 60;
					this.sum_time_minus = temp_minus % 60;
					money_3 = 350 * (this.sum_time_hour * 60 + this.sum_time_minus);
					this.money = money_1 + money_2 + money_3;
				}
			}else if (this.hour_begin < 17)
			{
				if (this.hour_end <= 17)
				{
					temp_hour = 16 - this.hour_begin;
					temp_minus = 60 + this.minus_end - this.minus_begin;
					this.sum_time_hour = temp_hour + (int)temp_minus / 60;
					this.sum_time_minus = temp_minus % 60;
					money_1 = 300 * (temp_hour * 60 + temp_minus);
					this.money = money_1;
				}
				else if(this.hour_end <= 24)
				{
					temp_hour = 17 - this.hour_begin;
					money_1 = 300 * (temp_hour * 60);
					this.sum_time_hour = temp_hour;
					temp_hour = this.hour_end - 7;
					this.sum_time_hour = this.sum_time_hour + temp_hour - 1;
					temp_minus = 60 + this.minus_end - this.minus_begin;
					this.sum_time_hour = this.sum_time_hour + (int)temp_minus / 60;
					this.sum_time_minus = temp_minus % 60;
					money_2 = 400 * (this.sum_time_hour * 60 + this.sum_time_minus);
					this.money = money_1 + money_2;
				}
				else
				{
					temp_hour = 17 - this.hour_begin;
					money_1 = 300 * (temp_hour * 60);
					money_2 = 400 * 10 * 60 * 0.9;
					this.sum_time_hour = temp_hour + 10;
					temp_hour = this.hour_end - 17;
					this.sum_time_hour = this.sum_time_hour + temp_hour - 1;
					temp_minus = 60 + this.minus_end - this.minus_begin;
					this.sum_time_hour = this.sum_time_hour + (int)temp_minus / 60;
					this.sum_time_minus = temp_minus % 60;
					money_3 = 350 * (this.sum_time_hour * 60 + this.sum_time_minus);
					this.money = money_1 + money_2 + money_3;
				}
			}
			else
			{
				if (this.hour_end <= 24)
				{
					temp_hour = 23 - this.hour_begin;
					temp_minus = 60 + this.minus_end - this.minus_begin;
					this.sum_time_hour = temp_hour + (int)temp_minus / 60;
					this.sum_time_minus = temp_minus % 60;
					money_1 = 300 * (temp_hour * 60 + temp_minus);
					this.money = money_1;
				}
				else if (this.hour_end <= 24)
				{
					temp_hour = 24 - this.hour_begin;
					money_1 = 300 * (temp_hour * 60);
					this.sum_time_hour = temp_hour;
					temp_hour = this.hour_end - 7;
					this.sum_time_hour = this.sum_time_hour + temp_hour - 1;
					temp_minus = 60 + this.minus_end - this.minus_begin;
					this.sum_time_hour = this.sum_time_hour + (int)temp_minus / 60;
					this.sum_time_minus = temp_minus % 60;
					money_2 = 400 * (this.sum_time_hour * 60 + this.sum_time_minus);
					this.money = money_1 + money_2;
				}
				else
				{
					temp_hour = 24 - this.hour_begin;
					money_1 = 300 * (temp_hour * 60);
					money_2 = 400 * 10 * 60 * 0.9;
					this.sum_time_hour = temp_hour + 10;
					temp_hour = this.hour_end - 17;
					this.sum_time_hour = this.sum_time_hour + temp_hour - 1;
					temp_minus = 60 + this.minus_end - this.minus_begin;
					this.sum_time_hour = this.sum_time_hour + (int)temp_minus / 60;
					this.sum_time_minus = temp_minus % 60;
					money_3 = 350 * (this.sum_time_hour * 60 + this.sum_time_minus);
					this.money = money_1 + money_2 + money_3;
				}
			}

			
		}
	}
}
