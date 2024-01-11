import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  template: `
    <div class="content-container">
      <div class="content-title-group">
        <h2 class="title">SWA Fanclub Merchandise @Ordina 2024</h2>
        <p>
        Order your favorite SWA gadgets and merchandise! Become a preferred customer and gain access
        to discount codes, too.
        </p>
        <p>Log in to start enjoying your benefits</p>
        <br />

        <div class="button-group">
          <button class="button" aria-label="My List" tabindex="0">
            <a href="/products">
              <i class="fas fa-clipboard-list"></i>
              My List
            </a>
          </button>
          <button class="button" aria-label="My Discounts">
            <a href="/discounts">
              <i class="fas fa-money-bill-alt"></i>
              My Discounts
            </a>
          </button>
        </div>
      </div>
    </div>
  `,
})
export class HomeComponent {}
