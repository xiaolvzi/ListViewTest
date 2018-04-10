using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Java.Lang;
using Android.Content;
using System.Collections.Generic;
using Android.Graphics;
using Android.Util;

namespace ListViewTest
{
    [Activity(Label = "ListViewTest", MainLauncher = true)]
    public class MainActivity : Activity
    {
        ListView mListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            mListView = FindViewById<ListView>(Resource.Id.listview);
            List<string> list = new List<string>();

            for (int i=0;i<30;i++) {
                list.Add(i + "");
            }
            MyAdapter adapter = new MyAdapter(this,list);
            mListView.Adapter = adapter;


        }

        class MyAdapter : BaseAdapter
        {
            Context mContext;
            List<string> mitems;
            List<int> mList;
            public MyAdapter(Context context, List<string> list){
                this.mContext = context;
                this.mitems = list;
                mList = new List<int>();
            }
            public override int Count {
                get {
                    return mitems.Count;
                }
            }

            public override Object GetItem(int position)
            {
                return mitems[position];
            }

            public override long GetItemId(int position)
            {
                return position;
            }

            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                DataViewHolder holder = null;
                if (convertView == null)
                {
                    convertView = LayoutInflater.From(mContext).Inflate(Resource.Layout.item_layout, null, false);
                    holder = new DataViewHolder();
                    holder.txtDescription = convertView.FindViewById<TextView>(Resource.Id.txtDescription);
                    
                    holder.txtDescription.Click += delegate
                    {
                        Log.Error("lv", "" + (int)holder.txtDescription.Tag);
                        mList.Add((int)holder.txtDescription.Tag);
                        holder.txtDescription.SetBackgroundColor(Color.Red);
                    };
                    convertView.Tag = holder;
                }
                else
                {
                    holder = convertView.Tag as DataViewHolder;
                    
                }
                holder.txtDescription.Tag = position;
                Log.Error("position", "" + position);
                holder.txtDescription.Text = mitems[position];
                
                if (!mList.Contains(position))
                {
                    Log.Error("-----", "--------------");
                    holder.txtDescription.SetBackgroundColor(Color.Transparent);

                }
                else {
                    Log.Error("++++", "+++++++++++++");
                    holder.txtDescription.SetBackgroundColor(Color.Red);
                }

                return convertView;

            }


        }

        public class DataViewHolder : Java.Lang.Object
        {
            public TextView txtDescription { get; set; }

        }
    }
}

