﻿Public Class Form1


	' COokie Time Machine



	Dim StartingClicker As Boolean

	Public FontChangedGame As Boolean

	Dim WakeUpDelayGrandma As Boolean
	Dim WakeUpDelayFactory As Boolean
	Dim WakeUpDelayMine As Boolean
	Dim WakeUpDelayFarm As Boolean
	Dim WakeUpDelayGirlScout As Boolean
	Dim WakeUpDelayScience As Boolean
	Dim WakeUpDelayCookieGod As Boolean
	Dim WakeUpDelayMachine As Boolean

	Dim WakeUpDelayIntegerGrandma As Integer
	Dim WakeUpDelayIntegerMine As Integer
	Dim WakeUpDelayIntegerFactory As Integer
	Dim WakeUpDelayIntegerGirlScout As Integer
	Dim WakeUpDelayIntegerFarm As Integer
	Dim WakeUpDelayIntegerScience As Integer
	Dim WakeUpDelayIntegerCookieGod As Integer
	Dim WakeupDelayIntegerMachine As Integer


	Dim LivesGrandma As Integer = 750
	Dim LivesGirlScout As Integer = 700
	Dim LivesFarm As Integer = 650
	Dim LivesFactory As Integer = 600
	Dim LivesMine As Integer = 550
	Dim LivesScience As Integer = 500
	Dim LivesCookieGod As Integer = 450
	Dim LivesMachine As Integer = 300


	Dim GrandmaAlreadyAlive As Boolean = False
	Dim GirlScoutAlreadyALive As Boolean = False
	Dim FarmAlreadyAlive As Boolean = False
	Dim FactoryAlreadyAlive As Boolean = False
	Dim MineAlreadyAlive As Boolean = False
	Dim ScienceAlreadyAlive As Boolean = False
	Dim CookieGodAlreadyAlive As Boolean = False
	Dim MachineAlreadyAlive As Boolean = False

	Public Cookies As Integer = 100000

	Dim GrandmaAlive As Boolean = False
	Dim MineAlive As Boolean
	Dim GirlScoutAlive As Boolean
	Dim FactoryAlive As Boolean
	Dim FarmAlive As Boolean
	Dim ScienceAlive As Boolean
	Dim CookieGodAlive As Boolean
	Dim MachineAlive As Boolean

	Dim AlreadySleeping As Boolean = False




	Dim TempLivesSaveMine As Integer
	Dim TempLivesSaveGrandma As Integer
	Dim TempLivesSaveGirlScout As Integer
	Dim TempLivesSaveFactory As Integer
	Dim TempLivesSaveFarm As Integer
	Dim TempLivesSaveScience As Integer
	Dim TempLivesSaveCookieGod As Integer
	Dim TempLivesSaveMachine As Integer

	Dim AnotherBoolean As Boolean


	Public Test As Boolean



	Public Multiplier As Integer = 1
	Public MultiplierActive As Boolean

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		' -------------------------------------------------------------------------------------------------

		If GrandmaAlive = True Then
			LivesGrandma -= 1
		End If

		If FactoryAlive = True Then
			LivesFactory -= 1
		End If

		If GirlScoutAlive = True Then
			LivesGirlScout -= 1
		End If

		If MineAlive = True Then
			LivesMine -= 1
		End If

		If FarmAlive = True Then
			LivesFarm -= 1
		End If

		If ScienceAlive = True Then
			LivesScience -= 1
		End If

		If CookieGodAlive = True Then
			LivesCookieGod -= 1
		End If

		If MachineAlive = True Then
			LivesMachine -= 1
		End If


		Label6.Text = LivesGirlScout

		' -------------------------------------------------------------------------------------------------

		If LivesGrandma <= 0 And GrandmaAlive = True Then
			MsgBox("You're out of Lives for Grandma, Sorry!")
			GrandmaAlive = False
			StartingClicker = True
			LivesGrandma = 750
			GrandmaAlreadyAlive = False
		End If

		If LivesGirlScout <= 0 And GirlScoutAlive = True Then
			MsgBox("Your Girl Scout is getting tired and wants to go home, Sorry!")
			GirlScoutAlive = False
			StartingClicker = True
			LivesGirlScout = 700
			GirlScoutAlreadyALive = False
		End If


		If LivesFarm <= 0 And FarmAlive = True Then
			MsgBox("The community farm is now under maintenance, it seems it might never come back up, see you around.")
			FarmAlive = False
			StartingClicker = True
			LivesFarm = 650
			FarmAlreadyAlive = False
		End If


		If LivesFactory <= 0 And FactoryAlive = True Then
			MsgBox("You're out of Lives for The Factory, Sorry!")
			FactoryAlive = False
			StartingClicker = True
			LivesFactory = 600
			FactoryAlreadyAlive = False
		End If

		If LivesMine <= 0 And MineAlive = True Then
			MsgBox("The Mine is out of commission, sadly it's time for everyone to go home, come again soon!")
			MineAlive = False
			StartingClicker = True
			LivesMine = 550
			MineAlreadyAlive = False
		End If

		If LivesScience <= 0 And ScienceAlive = True Then
			MsgBox("The Lab is out of control! It's getting too hectic in here so we have to shut er down for now!")
			ScienceAlive = False
			StartingClicker = True
			LivesScience = 500
			ScienceAlreadyAlive = False
		End If

		If LivesCookieGod <= 0 And CookieGodAlive = True Then
			MsgBox("The Cookie God is starting to get a mind for its own, we need to take him apart for now!")
			CookieGodAlive = False
			StartingClicker = True
			LivesCookieGod = 450
			CookieGodAlreadyAlive = False
		End If

		If LivesMachine <= 0 And MachineAlive = True Then
			MsgBox("The Time Machine is on the fritz, we need to make sure it doesn't cause any havoc so we're taking it down!")
			MachineAlive = False
			StartingClicker = True
			LivesMachine = 300
			MachineAlreadyAlive = False
		End If




		' -------------------------------------------------------------------------------------------------

		If MultiplierActive = True Then
			Multiplier = 2
		End If

		' -------------------------------------------------------------------------------------------------


		If GrandmaAlive = True Then
			Cookies += 5 * Multiplier
			StartingClicker = False
		End If

		If GirlScoutAlive = True Then
			Cookies += 10 * Multiplier
			StartingClicker = False
		End If

		If FarmAlive = True Then
			Cookies += 15 * Multiplier
			StartingClicker = False
		End If

		If FactoryAlive = True Then
			Cookies += 20 * Multiplier
			StartingClicker = False
		End If

		If MineAlive = True Then
			Cookies += 35 * Multiplier
			StartingClicker = False
		End If

		If ScienceAlive = True Then
			Cookies += 50 * Multiplier
			StartingClicker = False
		End If

		If CookieGodAlive = True Then
			Cookies += 75 * Multiplier
			StartingClicker = False
		End If

		If MachineAlive = True Then
			Cookies += 500 * Multiplier
			StartingClicker = False
		End If

		' -------------------------------------------------------------------------------------------------




		If Cookies >= 100000000 Then
			MsgBox("Wowzers, You beat the Game! Must've taken a while huh? Great Job!")
			MsgBox("Of Course You can continue playing but that's all i've got for you, Awesome Job once again!")
		End If



		If StartingClicker = True Then
			Cookies += 1
		End If

		TextBox1.Text = CInt(Int((100 * Rnd()) + 1))

		' -------------------------------------------------------------------------------------------------

		If TextBox1.Text = 10 And GrandmaAlive = True Then
			MsgBox("Grandma Is Sleepy, Wait 5 Clicks before she wakes up!")
			GrandmaAlive = False
			TempLivesSaveGrandma = LivesGrandma
			WakeUpDelayGrandma = True
			AnotherBoolean = False
			WakeUpDelayIntegerGrandma = 5
		End If

		If WakeUpDelayIntegerGrandma = 0 And WakeUpDelayGrandma = True Then
			MsgBox("Grandma is Done Sleeping, Get her back to work, we need to get some cookies!")
			WakeUpDelayGrandma = False
			GrandmaAlive = True
			LivesGrandma = TempLivesSaveGrandma
		End If


		' -------------------------------------------------------------------------------------------------

		If TextBox1.Text = 15 And GirlScoutAlive = True Then
			MsgBox("Your Girl Scout is getting bored, sadly you have to wait 7 turns to get her back in motion.")
			GirlScoutAlive = False
			TempLivesSaveGirlScout = LivesGirlScout
			WakeUpDelayGirlScout = True
			AnotherBoolean = False
			WakeUpDelayIntegerGirlScout = 7
		End If

		If WakeUpDelayIntegerGirlScout = 0 And WakeUpDelayGirlScout = True Then
			MsgBox("Your GirlScout is as peppy as ever, she is bursting at the seems to go to more houses, let's get her to some more houses!")
			WakeUpDelayGirlScout = False
			GirlScoutAlive = True
			LivesGirlScout = TempLivesSaveGirlScout
		End If

		' -------------------------------------------------------------------------------------------------

		If TextBox1.Text = 20 And FactoryAlive = True Then
			MsgBox("The Factory is Under Maintenance, wait 10 turns before it resumes working.")
			FactoryAlive = False
			TempLivesSaveFactory = LivesFactory
			WakeUpDelayFactory = True
			AnotherBoolean = False
			WakeUpDelayIntegerFactory = 10
		End If

		If WakeUpDelayIntegerFactory = 0 And WakeUpDelayFactory = True Then
			MsgBox("The Factory is operational again, get it back to work!")
			WakeUpDelayFactory = False
			FactoryAlive = True
			LivesFactory = TempLivesSaveFactory
		End If

		' -------------------------------------------------------------------------------------------------


		If TextBox1.Text = 25 And MineAlive = True Then
			MsgBox("The Workers of the Mine are Tired, they'll be working again in 15 turns.")
			MineAlive = False
			TempLivesSaveMine = LivesMine
			WakeUpDelayMine = True
			AnotherBoolean = False
			WakeUpDelayIntegerMine = 15
		End If

		If WakeUpDelayIntegerMine = 0 And WakeUpDelayMine = True Then
			MsgBox("The Workers of the Mine are Ready to continue Working, Get them back to work!")
			WakeUpDelayMine = False
			MineAlive = True
			LivesMine = TempLivesSaveMine
		End If

		' --------------------------------------------------------------------------------------------------


		If TextBox1.Text = 18 And FarmAlive = True Then
			MsgBox("The workers at the farm are too sunburnt to keep working, let's give them a 9 turn break, huh?")
			FarmAlive = False
			TempLivesSaveFarm = LivesFarm
			WakeUpDelayFarm = True
			AnotherBoolean = False
			WakeUpDelayIntegerFarm = 9
		End If

		If WakeUpDelayIntegerFarm = 0 And WakeUpDelayFarm = True Then
			MsgBox("The Farm workers are now all sunscreened up, let's get em back to work!")
			WakeUpDelayFarm = False
			FarmAlive = True
			LivesFarm = TempLivesSaveFarm
		End If

		' --------------------------------------------------------------------------------------------------

		If TextBox1.Text = 13 And ScienceAlive = True Then
			MsgBox("These Science Experiments are very stressful on the scientists, let's give them a 20 turn break to cool off.")
			ScienceAlive = False
			TempLivesSaveScience = LivesScience
			WakeUpDelayScience = True
			AnotherBoolean = False
			WakeUpDelayIntegerScience = 20
		End If


		If WakeUpDelayIntegerScience = 0 And WakeUpDelayScience = True Then
			MsgBox("The Scientists are now as relaxed as ever, they're ready to get back to work!")
			WakeUpDelayScience = False
			ScienceAlive = True
			LivesScience = TempLivesSaveScience
		End If


		' --------------------------------------------------------------------------------------------------

		If TextBox1.Text = 74 And CookieGodAlive = True Then
			MsgBox("The Cookie God is getting pretty tired or all your demands, let's give him a 30 turn break so he can calm down.")
			CookieGodAlive = False
			TempLivesSaveCookieGod = LivesCookieGod
			WakeUpDelayCookieGod = True
			AnotherBoolean = False
			WakeUpDelayIntegerCookieGod = 30
		End If


		If WakeUpDelayIntegerCookieGod = 0 And WakeUpDelayCookieGod = True Then
			MsgBox("He seems to be much more calm, let's keep giving him demands because that's for sure a good idea!")
			WakeUpDelayCookieGod = False
			CookieGodAlive = True
			LivesCookieGod = TempLivesSaveCookieGod
		End If


		' --------------------------------------------------------------------------------------------------

		If TextBox1.Text = 61 And MachineAlive = True Then
			MsgBox("The Time Machine overheated, if you use it anymore catastrophic things will ensue, let's give it a 40 turn break from working so hard!")
			MachineAlive = False
			TempLivesSaveMachine = LivesMachine
			WakeUpDelayMachine = True
			AnotherBoolean = False
			WakeupDelayIntegerMachine = 40
		End If


		If WakeupDelayIntegerMachine = 0 And WakeUpDelayMachine = True Then
			MsgBox("The Machine seems to be much more stable, let's try using it again!")
			WakeUpDelayMachine = False
			MachineAlive = True
			LivesMachine = TempLivesSaveMachine
		End If

		' --------------------------------------------------------------------------------------------------


		If WakeUpDelayGrandma = True Then
			WakeUpDelayIntegerGrandma -= 1
		End If

		If WakeUpDelayFactory = True Then
			WakeUpDelayIntegerFactory -= 1
		End If

		If WakeUpDelayGirlScout = True Then
			WakeUpDelayIntegerGirlScout -= 1
		End If

		If WakeUpDelayMine = True Then
			WakeUpDelayIntegerMine -= 1
		End If

		If WakeUpDelayFarm = True Then
			WakeUpDelayIntegerFarm -= 1
		End If

		If WakeUpDelayScience = True Then
			WakeUpDelayIntegerScience -= 1
		End If

		If WakeUpDelayCookieGod = True Then
			WakeUpDelayIntegerCookieGod -= 1
		End If

		If WakeUpDelayMachine = True Then
			WakeupDelayIntegerMachine -= 1
		End If


		' -------------------------------------------------------------------------------------------------

		Label5.Text = WakeUpDelayIntegerFactory

		Label2.Text = WakeUpDelayIntegerGrandma

		StartingClicker = True

		Label1.Text = Cookies
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		If Cookies >= 10 And GrandmaAlreadyAlive = False Then
			GrandmaAlive = True
			Cookies -= 10
			Label1.Text = Cookies
			GrandmaAlreadyAlive = True
		End If
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		If Cookies >= 500 And FactoryAlreadyAlive = False Then
			FactoryAlive = True
			Cookies -= 500
			Label1.Text = Cookies
			FactoryAlreadyAlive = True
		End If
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		Form2.Show()
		If FontChangedGame = True Then

			Form2.Button1.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
			Form2.Button2.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
			Form2.Button3.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)

		End If

	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		If Cookies >= 250 And GirlScoutAlreadyALive = False Then
			GirlScoutAlive = True
			Cookies -= 250
			Label1.Text = Cookies
			GirlScoutAlreadyALive = True
		End If
	End Sub

	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
		If Cookies >= 2000 And MineAlreadyAlive = False Then
			MineAlive = True
			Cookies -= 2000
			Label1.Text = Cookies
			MineAlreadyAlive = True
		End If
	End Sub

	Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
		If Cookies >= 350 And FarmAlreadyAlive = False Then
			FarmAlive = True
			Cookies -= 350
			Label1.Text = Cookies
			FarmAlreadyAlive = True
		End If
	End Sub

	Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
		If Cookies >= 5000 And ScienceAlreadyAlive = False Then
			ScienceAlive = True
			Cookies -= 5000
			Label1.Text = Cookies
			ScienceAlreadyAlive = True
		End If
	End Sub

	Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
		If Cookies >= 10000 And CookieGodAlreadyAlive = False Then
			CookieGodAlive = True
			Cookies -= 10000
			Label1.Text = Cookies
			CookieGodAlreadyAlive = True
		End If
	End Sub

	Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
		If Cookies >= 100000 And MachineAlreadyAlive = False Then
			MachineAlive = True
			Cookies -= 100000
			Label1.Text = Cookies
			MachineAlreadyAlive = True
		End If
	End Sub
End Class
