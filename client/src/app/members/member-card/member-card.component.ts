import { Component, input, OnInit } from '@angular/core';
import { Member } from '../../../_models/member';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-member-card',
  imports: [RouterLink],
  templateUrl: './member-card.component.html',
  styleUrl: './member-card.component.css',
})
export class MemberCardComponent implements OnInit {
  member = input.required<Member>();

  ngOnInit() {
    console.log(this.member()); // Log the value of the input
  }
}
