# Generated by Django 3.0.6 on 2020-06-04 08:10

from django.db import migrations, models


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='DataMember',
            fields=[
                ('comment', models.CharField(max_length=40)),
                ('id', models.IntegerField(primary_key=True, serialize=False)),
            ],
        ),
    ]
